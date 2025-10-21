using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BotChannelLine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.botChannelLine.BotChannelLineLineChannel")]
    public class BotChannelLineLineChannel : azurerm.BotChannelLine.IBotChannelLineLineChannel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#access_token BotChannelLine#access_token}.</summary>
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#secret BotChannelLine#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public string Secret
        {
            get;
            set;
        }
    }
}
