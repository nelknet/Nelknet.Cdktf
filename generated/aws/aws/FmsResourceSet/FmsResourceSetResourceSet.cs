using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsResourceSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fmsResourceSet.FmsResourceSetResourceSet")]
    public class FmsResourceSetResourceSet : aws.FmsResourceSet.IFmsResourceSetResourceSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#name FmsResourceSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#description FmsResourceSet#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_set_status FmsResourceSet#resource_set_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceSetStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceSetStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_type_list FmsResourceSet#resource_type_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypeList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#update_token FmsResourceSet#update_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateToken
        {
            get;
            set;
        }
    }
}
