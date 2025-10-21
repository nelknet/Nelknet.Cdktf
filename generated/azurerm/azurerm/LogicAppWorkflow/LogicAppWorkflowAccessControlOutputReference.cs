using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    [JsiiClass(nativeType: typeof(azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlOutputReference), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LogicAppWorkflowAccessControlOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LogicAppWorkflowAccessControlOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogicAppWorkflowAccessControlOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogicAppWorkflowAccessControlOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlAction\"}}]")]
        public virtual void PutAction(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlContent\"}}]")]
        public virtual void PutContent(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger\"}}]")]
        public virtual void PutTrigger(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkflowManagement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagement\"}}]")]
        public virtual void PutWorkflowManagement(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContent")]
        public virtual void ResetContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrigger")]
        public virtual void ResetTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkflowManagement")]
        public virtual void ResetWorkflowManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlActionOutputReference\"}")]
        public virtual azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlActionOutputReference Action
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlActionOutputReference>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlContentOutputReference\"}")]
        public virtual azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlContentOutputReference Content
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlContentOutputReference>()!;
        }

        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOutputReference\"}")]
        public virtual azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlTriggerOutputReference Trigger
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "workflowManagement", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagementOutputReference\"}")]
        public virtual azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagementOutputReference WorkflowManagement
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlAction\"}", isOptional: true)]
        public virtual azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction? ActionInput
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentInput", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlContent\"}", isOptional: true)]
        public virtual azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent? ContentInput
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerInput", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger\"}", isOptional: true)]
        public virtual azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger? TriggerInput
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workflowManagementInput", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagement\"}", isOptional: true)]
        public virtual azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement? WorkflowManagementInput
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControl\"}", isOptional: true)]
        public virtual azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControl? InternalValue
        {
            get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControl?>();
            set => SetInstanceProperty(value);
        }
    }
}
