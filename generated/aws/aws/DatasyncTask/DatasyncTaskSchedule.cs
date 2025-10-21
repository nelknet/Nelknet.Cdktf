using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncTask.DatasyncTaskSchedule")]
    public class DatasyncTaskSchedule : aws.DatasyncTask.IDatasyncTaskSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#schedule_expression DatasyncTask#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string ScheduleExpression
        {
            get;
            set;
        }
    }
}
