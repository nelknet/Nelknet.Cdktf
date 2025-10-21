using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsResourceSet
{
    [JsiiInterface(nativeType: typeof(IFmsResourceSetResourceSet), fullyQualifiedName: "aws.fmsResourceSet.FmsResourceSetResourceSet")]
    public interface IFmsResourceSetResourceSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#name FmsResourceSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#description FmsResourceSet#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_set_status FmsResourceSet#resource_set_status}.</summary>
        [JsiiProperty(name: "resourceSetStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceSetStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_type_list FmsResourceSet#resource_type_list}.</summary>
        [JsiiProperty(name: "resourceTypeList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypeList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#update_token FmsResourceSet#update_token}.</summary>
        [JsiiProperty(name: "updateToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFmsResourceSetResourceSet), fullyQualifiedName: "aws.fmsResourceSet.FmsResourceSetResourceSet")]
        internal sealed class _Proxy : DeputyBase, aws.FmsResourceSet.IFmsResourceSetResourceSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#name FmsResourceSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#description FmsResourceSet#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_set_status FmsResourceSet#resource_set_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceSetStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceSetStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_type_list FmsResourceSet#resource_type_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypeList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#update_token FmsResourceSet#update_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
