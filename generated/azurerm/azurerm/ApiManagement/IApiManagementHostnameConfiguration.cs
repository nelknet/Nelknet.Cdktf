using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementHostnameConfiguration), fullyQualifiedName: "azurerm.apiManagement.ApiManagementHostnameConfiguration")]
    public interface IApiManagementHostnameConfiguration
    {
        /// <summary>developer_portal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#developer_portal ApiManagement#developer_portal}
        /// </remarks>
        [JsiiProperty(name: "developerPortal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationDeveloperPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeveloperPortal
        {
            get
            {
                return null;
            }
        }

        /// <summary>management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#management ApiManagement#management}
        /// </remarks>
        [JsiiProperty(name: "management", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Management
        {
            get
            {
                return null;
            }
        }

        /// <summary>portal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#portal ApiManagement#portal}
        /// </remarks>
        [JsiiProperty(name: "portal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Portal
        {
            get
            {
                return null;
            }
        }

        /// <summary>proxy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#proxy ApiManagement#proxy}
        /// </remarks>
        [JsiiProperty(name: "proxy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationProxy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Proxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>scm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#scm ApiManagement#scm}
        /// </remarks>
        [JsiiProperty(name: "scm", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationScm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Scm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementHostnameConfiguration), fullyQualifiedName: "azurerm.apiManagement.ApiManagementHostnameConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementHostnameConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>developer_portal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#developer_portal ApiManagement#developer_portal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "developerPortal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationDeveloperPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeveloperPortal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#management ApiManagement#management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "management", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Management
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>portal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#portal ApiManagement#portal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Portal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>proxy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#proxy ApiManagement#proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationProxy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Proxy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#scm ApiManagement#scm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scm", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationScm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Scm
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
