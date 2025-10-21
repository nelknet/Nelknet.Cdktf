using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridTopic
{
    [JsiiInterface(nativeType: typeof(IEventgridTopicInboundIpRule), fullyQualifiedName: "azurerm.eventgridTopic.EventgridTopicInboundIpRule")]
    public interface IEventgridTopicInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#action EventgridTopic#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#ip_mask EventgridTopic#ip_mask}.</summary>
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpMask
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridTopicInboundIpRule), fullyQualifiedName: "azurerm.eventgridTopic.EventgridTopicInboundIpRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridTopic.IEventgridTopicInboundIpRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#action EventgridTopic#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#ip_mask EventgridTopic#ip_mask}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpMask
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
