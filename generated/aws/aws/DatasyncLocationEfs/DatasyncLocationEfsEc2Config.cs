using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationEfs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncLocationEfs.DatasyncLocationEfsEc2Config")]
    public class DatasyncLocationEfsEc2Config : aws.DatasyncLocationEfs.IDatasyncLocationEfsEc2Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#security_group_arns DatasyncLocationEfs#security_group_arns}.</summary>
        [JsiiProperty(name: "securityGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#subnet_arn DatasyncLocationEfs#subnet_arn}.</summary>
        [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetArn
        {
            get;
            set;
        }
    }
}
