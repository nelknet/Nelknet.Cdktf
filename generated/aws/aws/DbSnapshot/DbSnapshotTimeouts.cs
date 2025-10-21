using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbSnapshot
{
    [JsiiByValue(fqn: "aws.dbSnapshot.DbSnapshotTimeouts")]
    public class DbSnapshotTimeouts : aws.DbSnapshot.IDbSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#create DbSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
