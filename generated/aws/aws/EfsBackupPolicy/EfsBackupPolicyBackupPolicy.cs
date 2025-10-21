using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsBackupPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.efsBackupPolicy.EfsBackupPolicyBackupPolicy")]
    public class EfsBackupPolicyBackupPolicy : aws.EfsBackupPolicy.IEfsBackupPolicyBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy#status EfsBackupPolicy#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
