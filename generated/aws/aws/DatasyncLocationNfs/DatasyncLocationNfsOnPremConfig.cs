using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationNfs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncLocationNfs.DatasyncLocationNfsOnPremConfig")]
    public class DatasyncLocationNfsOnPremConfig : aws.DatasyncLocationNfs.IDatasyncLocationNfsOnPremConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#agent_arns DatasyncLocationNfs#agent_arns}.</summary>
        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AgentArns
        {
            get;
            set;
        }
    }
}
