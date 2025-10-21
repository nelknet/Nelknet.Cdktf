using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppActionHttp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.logicAppActionHttp.LogicAppActionHttpRunAfter")]
    public class LogicAppActionHttpRunAfter : azurerm.LogicAppActionHttp.ILogicAppActionHttpRunAfter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#action_name LogicAppActionHttp#action_name}.</summary>
        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#action_result LogicAppActionHttp#action_result}.</summary>
        [JsiiProperty(name: "actionResult", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionResult
        {
            get;
            set;
        }
    }
}
