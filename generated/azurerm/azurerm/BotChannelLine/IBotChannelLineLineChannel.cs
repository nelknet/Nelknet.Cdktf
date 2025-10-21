using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BotChannelLine
{
    [JsiiInterface(nativeType: typeof(IBotChannelLineLineChannel), fullyQualifiedName: "azurerm.botChannelLine.BotChannelLineLineChannel")]
    public interface IBotChannelLineLineChannel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#access_token BotChannelLine#access_token}.</summary>
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
        string AccessToken
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#secret BotChannelLine#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        string Secret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBotChannelLineLineChannel), fullyQualifiedName: "azurerm.botChannelLine.BotChannelLineLineChannel")]
        internal sealed class _Proxy : DeputyBase, azurerm.BotChannelLine.IBotChannelLineLineChannel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#access_token BotChannelLine#access_token}.</summary>
            [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessToken
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#secret BotChannelLine#secret}.</summary>
            [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
            public string Secret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
