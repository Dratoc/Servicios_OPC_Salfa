namespace CatalogSalfa.Entities
{

    public class ActivityFinancial
    {
        public int project { get; set; }
        public int wbsId { get; set; }
        public int activity { get; set; }
        public int activityId { get; set; }
        public int earnedValueCost { get; set; }
        public int plannedValueCost { get; set; }
        public int scheduleVariance { get; set; }
        public int earnedValueLaborUnits { get; set; }
        public double scheduleVarianceIndex { get; set; }
        public int costVarianceLaborUnits { get; set; }
        public double costVarianceIndex { get; set; }
        public double costVarianceLaborUnitsIndex { get; set; }
        public double schedulePerformanceIndex { get; set; }
        public double toCompletePerformanceIndex { get; set; }
        public int earnedValueCostProject { get; set; }
        public int plannedValueCostProject { get; set; }
        public int plannedLaborCost { get; set; }
        public int plannedLaborCostProject { get; set; }
        public int plannedMaterialCost { get; set; }
        public int plannedMaterialCostProject { get; set; }
        public int plannedTotalCost { get; set; }
        public int plannedTotalCostProject { get; set; }
        public int remainingLaborCost { get; set; }
        public int remainingLaborCostProject { get; set; }
        public int remainingMaterialCost { get; set; }
        public int remainingMaterialCostProject { get; set; }
        public int remainingTotalCost { get; set; }
        public int remainingTotalCostProject { get; set; }
        public int actualLaborCost { get; set; }
        public int actualLaborCostProject { get; set; }
        public int actualMaterialCost { get; set; }
        public int actualMaterialCostProject { get; set; }
        public int actualTotalCost { get; set; }
        public int actualTotalCostProject { get; set; }
        public int budgetAtCompletion { get; set; }
        public int budgetAtCompletionProject { get; set; }
        public int actualThisPeriodLaborCostProject { get; set; }
        public int plannedExpenseCost { get; set; }
        public int plannedNonLaborCost { get; set; }
        public int plannedNonLaborCostProject { get; set; }
        public int remainingExpenseCost { get; set; }
        public int remainingNonLaborCost { get; set; }
        public int remainingNonLaborCostProject { get; set; }
        public int actualExpenseCost { get; set; }
        public int actualNonLaborCost { get; set; }
        public int actualNonLaborCostProject { get; set; }
        public int atCompletionExpenseCost { get; set; }
        public int atCompletionLaborCost { get; set; }
        public int atCompletionLaborCostProject { get; set; }
        public int atCompletionMaterialCost { get; set; }
        public int atCompletionMaterialCostProject { get; set; }
        public int atCompletionNonLaborCost { get; set; }
        public int atCompletionNonLaborCostProject { get; set; }
        public int atCompletionTotalCost { get; set; }
        public int atCompletionTotalCostProject { get; set; }
        public int blplannedExpenseCost { get; set; }
        public int blplannedLaborCost { get; set; }
        public int blplannedMaterialCost { get; set; }
        public int blplannedNonLaborCost { get; set; }
        public int blplannedTotalCost { get; set; }
        public int accountingVariance { get; set; }
        public int expenseCostVariance { get; set; }
        public int laborCostVariance { get; set; }
        public int materialCostVariance { get; set; }
        public int nonLaborCostVariance { get; set; }
        public int totalCostVariance { get; set; }
        public int actualThisPeriodLaborCost { get; set; }
        public int actualThisPeriodNonLaborCost { get; set; }
        public int actualThisPeriodNonLaborCostProject { get; set; }
        public int actualThisPeriodMaterialCost { get; set; }
        public int actualThisPeriodMaterialCostProject { get; set; }
        public int actualThisPeriodTotalCost { get; set; }
        public int actualThisPeriodTotalCostProject { get; set; }
        public int priorActualLaborCost { get; set; }
        public int priorActualLaborCostProject { get; set; }
        public int priorActualNonLaborCost { get; set; }
        public int priorActualNonLaborCostProject { get; set; }
        public int priorActualMaterialCost { get; set; }
        public int priorActualMaterialCostProject { get; set; }
        public int priorActualTotalCost { get; set; }
        public int priorActualTotalCostProject { get; set; }
        public int scheduleVarianceProject { get; set; }
        public int varCost { get; set; }
        public int varCostProject { get; set; }
        public int estimateToCompletionCost { get; set; }
        public int estimateToCompletionCostProject { get; set; }
        public int estimateAtCompletionCost { get; set; }
        public int estimateAtCompletionCostProject { get; set; }
        public int atCompletionVariance { get; set; }
        public int atCompletionVarianceProject { get; set; }
        public DateTime updateDate { get; set; }
    }

    public class Activity
    {
        public int workManagerTaskUnplannedCount { get; set; }
        public int calendar { get; set; }
        public int sequenceNumber { get; set; }
        public string owner { get; set; }
        public string constraintType { get; set; }
        //public List<object> configuredFields { get; set; }
        public int projectId { get; set; }
        public string projectCode { get; set; }
        public string startDate { get; set; }
        public int wbsId { get; set; }
        public string workspaceCode { get; set; }
        public int activityId { get; set; }
        //public List<object> activityUncertainties { get; set; }
        public string calendarName { get; set; }
        public string percentCompleteWeightedBy { get; set; }
        public double actualDuration { get; set; }
        public double remainingDuration { get; set; }
        public double plannedDuration { get; set; }
        public int recordCount { get; set; }
        public double costPerformanceIndexLaborUnits { get; set; }
        public string activityName { get; set; }
        public ActivityFinancial activityFinancial { get; set; }
        public bool critical { get; set; }
        public bool drivingPath { get; set; }
        public int actualThisPeriodNonLaborUnits { get; set; }
        public double actualThisPeriodLaborUnits { get; set; }
        public string plannedStart { get; set; }
        public string actualStart { get; set; }
        public string secondaryConstraintType { get; set; }
        public int plannedNonLaborUnits { get; set; }
        public int actualNonLaborUnits { get; set; }
        public int remainingNonLaborUnits { get; set; }
        public double plannedLaborUnits { get; set; }
        public double remainingLaborUnits { get; set; }
        public int priorActualLaborUnits { get; set; }
        public int priorActualNonLaborUnits { get; set; }
        public double actualLaborUnits { get; set; }
        public string activityStatus { get; set; }
        public string percentCompleteType { get; set; }
        public double physicalPercentComplete { get; set; }
        public string durationType { get; set; }
        public string activityType { get; set; }
        public string activityPriority { get; set; }
        public bool starred { get; set; }
        public double atCompletionLaborUnits { get; set; }
        public int atCompletionNonLaborUnits { get; set; }
        public double atCompletionDuration { get; set; }
        public double durationPercentComplete { get; set; }
        public double durationPercentOfPlanned { get; set; }
        public double schedulePercentComplete { get; set; }
        public double laborUnitsCompletePercent { get; set; }
        public double nonLaborUnitsCompletePercent { get; set; }
        public double scopePercentComplete { get; set; }
        public double activityPercentComplete { get; set; }
        public double performancePercentComplete { get; set; }
        public double unitsPercentComplete { get; set; }
        public double remainingFloat { get; set; }
        public string activityWorkManagerTaskDateStatus { get; set; }
        public string activityWorkManagerTaskStatus { get; set; }
        public bool activityWorkManagerTaskStatusIndicator { get; set; }
        public int workManagerTaskCount { get; set; }
        public int workManagerTaskPlannedOutsideCount { get; set; }
        public int workManagerTaskPlannedNotCompleteCount { get; set; }
        public int workManagerTaskPlannedCompleteCount { get; set; }
        public bool programMilestone { get; set; }
        public int atCompletionBudgetLaborUnits { get; set; }
        public int plannedValueLaborUnits { get; set; }
        public int earnedValueLaborUnits { get; set; }
        public int scheduleVarianceLaborUnits { get; set; }
        public double scheduleVarianceIndex { get; set; }
        public double scheduleVarIndexLaborUnits { get; set; }
        public int costVarianceLaborUnits { get; set; }
        public double costVarianceIndex { get; set; }
        public double costVarianceLaborUnitsIndex { get; set; }
        public double schedulePerformanceIndex { get; set; }
        public double schedulePerfIndexLaborUnits { get; set; }
        public double costPerformanceIndex { get; set; }
        public double estimateToCompletionLaborUnits { get; set; }
        public double toCompletePerformanceIndex { get; set; }
        public double estimateAtCompletionLaborUnits { get; set; }
        public int varianceAtCompletionLaborUnits { get; set; }
        public string activityCode { get; set; }
        //public List<object> codeValuesActivity { get; set; }
        public DateTime updateDate { get; set; }
        public string finishDate { get; set; }
        public string plannedFinish { get; set; }
        public string actualFinish { get; set; }
        public string constraintDate { get; set; }
        public string remainingFinish { get; set; }
        public string earlyFinish { get; set; }
        public string lateFinish { get; set; }
        public double? freeFloat { get; set; }
        public double? totalFloat { get; set; }
        public string remainingLateFinish { get; set; }
        public string remainingStart { get; set; }
        public string earlyStart { get; set; }
        public string lateStart { get; set; }
        public string remainingLateStart { get; set; }
        public string resourceCodeList { get; set; }
        public string resourceNameList { get; set; }
        public string suspendDate { get; set; }
        public string resumeDate { get; set; }
        public List<WorkManagerTask> workManagerTask { get; set; }
    }
}