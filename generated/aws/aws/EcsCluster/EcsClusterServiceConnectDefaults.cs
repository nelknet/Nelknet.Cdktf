using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsCluster.EcsClusterServiceConnectDefaults")]
    public class EcsClusterServiceConnectDefaults : aws.EcsCluster.IEcsClusterServiceConnectDefaults
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#namespace EcsCluster#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }
    }
}
