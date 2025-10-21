using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppActionHttp
{
    [JsiiInterface(nativeType: typeof(ILogicAppActionHttpRunAfter), fullyQualifiedName: "azurerm.logicAppActionHttp.LogicAppActionHttpRunAfter")]
    public interface ILogicAppActionHttpRunAfter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#action_name LogicAppActionHttp#action_name}.</summary>
        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
        string ActionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#action_result LogicAppActionHttp#action_result}.</summary>
        [JsiiProperty(name: "actionResult", typeJson: "{\"primitive\":\"string\"}")]
        string ActionResult
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppActionHttpRunAfter), fullyQualifiedName: "azurerm.logicAppActionHttp.LogicAppActionHttpRunAfter")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppActionHttp.ILogicAppActionHttpRunAfter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#action_name LogicAppActionHttp#action_name}.</summary>
            [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#action_result LogicAppActionHttp#action_result}.</summary>
            [JsiiProperty(name: "actionResult", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionResult
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
