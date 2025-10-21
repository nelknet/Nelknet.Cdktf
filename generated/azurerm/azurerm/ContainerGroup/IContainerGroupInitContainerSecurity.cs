using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    [JsiiInterface(nativeType: typeof(IContainerGroupInitContainerSecurity), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupInitContainerSecurity")]
    public interface IContainerGroupInitContainerSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#privilege_enabled ContainerGroup#privilege_enabled}.</summary>
        [JsiiProperty(name: "privilegeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object PrivilegeEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerGroupInitContainerSecurity), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupInitContainerSecurity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerGroup.IContainerGroupInitContainerSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#privilege_enabled ContainerGroup#privilege_enabled}.</summary>
            [JsiiProperty(name: "privilegeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object PrivilegeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
