using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppDapr), fullyQualifiedName: "azurerm.containerApp.ContainerAppDapr")]
    public interface IContainerAppDapr
    {
        /// <summary>The Dapr Application Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_id ContainerApp#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>The port which the application is listening on. This is the same as the `ingress` port.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_port ContainerApp#app_port}
        /// </remarks>
        [JsiiProperty(name: "appPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AppPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_protocol ContainerApp#app_protocol}
        /// </remarks>
        [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppDapr), fullyQualifiedName: "azurerm.containerApp.ContainerAppDapr")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppDapr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Dapr Application Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_id ContainerApp#app_id}
            /// </remarks>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The port which the application is listening on. This is the same as the `ingress` port.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_port ContainerApp#app_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AppPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#app_protocol ContainerApp#app_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
