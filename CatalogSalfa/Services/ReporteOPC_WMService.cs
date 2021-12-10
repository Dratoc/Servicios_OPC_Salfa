using CatalogSalfa.Dtos;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class ReporteOPC_WMService : IReporteOPC_WM
    {
        public async Task<ReporteOPC_WM> GetReporteOPC_WMs(string code)
        {
            TokenService service = new TokenService();
            var token = await service.GetTokenAsync();

            ProjectService serviceProject = new ProjectService();
            List<Project> projects = await serviceProject.GetProjectsAsyncToken(code, token);

            for (int i = 0; i < projects.Count; i++)
            {
                ActivityService activityService = new ActivityService();
                List<Activity> activities = await activityService.GetActivityAsyncToken(projects[i].projectId, token);
                projects[i].activities = activities;

                for (int a = 0; a < activities.Count; a++)
                {
                    WorkManagerTaskService serviceWorkManagerTask = new WorkManagerTaskService();
                    List<WorkManagerTask> workManagerTask = await serviceWorkManagerTask.GetWorkManagerTasksAsyncToken(projects[i].projectId, activities[a].activityId, token);

                    for (int w = 0; w < workManagerTask.Count; w++)
                    {
                        UserService userService = new UserService();
                        User user = await userService.GetUserAsyncToken(workManagerTask[w].userId, token);
                        workManagerTask[w].user = user;

                        ConstraintService serviceConstraint = new ConstraintService();
                        List<Constraint> constraint = await serviceConstraint.GetConstraintsAsyncToken(workManagerTask[w].workManagerTaskId, token);
                        workManagerTask[w].constraint = constraint;

                        WorkManagerTaskCommitmentService serviceWorkManagerTaskCommitment = new WorkManagerTaskCommitmentService();
                        List<WorkManagerTaskCommitment> workManagerTaskCommitment = await serviceWorkManagerTaskCommitment.GetWorkManagerTaskCommitmentAsyncToken(workManagerTask[w].workManagerTaskId, token);
                        workManagerTask[w].workManagerTaskCommitment = workManagerTaskCommitment;
                    }

                    activities[a].workManagerTask = workManagerTask;
                }

                projects[i].activities = activities;
            }

            ReporteOPC_WM reporte = new ReporteOPC_WM()
            {
                projects = projects
            };

            return reporte;

        }
    }


}