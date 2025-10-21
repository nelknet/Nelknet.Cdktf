using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppDapr")]
    public class ContainerAppDapr : azurerm.ContainerApp.IContainerAppDapr
    {
        /// <summary>The Dapr Application Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_id ContainerApp#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public string AppId
        {
            get;
            set;
        }

        /// <summary>The port which the application is listening on. This is the same as the `ingress` port.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_port ContainerApp#app_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AppPort
        {
            get;
            set;
        }

        /// <summary>The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_protocol ContainerApp#app_protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppProtocol
        {
            get;
            set;
        }
    }
}
