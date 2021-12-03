using CatalogSalfa.Dtos;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class ReporteOPC_WMService : IReporteOPC_WM
    {
        public async Task<ReporteOPC_WM> GetReporteOPC_WMs(string code)
        {

            ProjectService serviceProject = new ProjectService();
            List<Project> projects = await serviceProject.GetProjectsAsync(code);
            List<Reason> reason = new List<Reason>();

            for (int i = 0; i < projects.Count; i++)
            {
                WorkManagerTaskService serviceWorkManagerTask = new WorkManagerTaskService();
                List<WorkManagerTask> workManagerTask = await serviceWorkManagerTask.GetWorkManagerTasksAsync(projects[i].projectId);

                ConstraintService serviceConstraint = new ConstraintService();
                List<Constraint> constraint = await serviceConstraint.GetConstraintsAsync(projects[i].projectId);

                ReasonService serviceReason = new ReasonService();
                reason = await serviceReason.GetReasonAsync(projects[i].workspaceId);

                for (int w = 0; w < workManagerTask.Count; w++)
                {
                    UserService userService = new UserService();
                    User user = await userService.GetUserAsync(workManagerTask[w].userId);
                    workManagerTask[w].user = user;

                    ActivityService activityService = new ActivityService();
                    Activity activity = await activityService.GetActivityAsync(workManagerTask[w].activityId);
                    workManagerTask[w].activity = activity;
                }

                projects[i].constraint = constraint;
                projects[i].workManagerTask = workManagerTask;
            }

            ReporteOPC_WM reporte = new ReporteOPC_WM()
            {
                projects = projects,
                reason = reason
            };

            return reporte;

        }
    }


}