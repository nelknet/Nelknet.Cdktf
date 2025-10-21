using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchAccount
{
    [JsiiClass(nativeType: typeof(azurerm.BatchAccount.BatchAccountNetworkProfileOutputReference), fullyQualifiedName: "azurerm.batchAccount.BatchAccountNetworkProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchAccountNetworkProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchAccountNetworkProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchAccountNetworkProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchAccountNetworkProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccountAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileAccountAccess\"}}]")]
        public virtual void PutAccountAccess(azurerm.BatchAccount.IBatchAccountNetworkProfileAccountAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchAccount.IBatchAccountNetworkProfileAccountAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeManagementAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccess\"}}]")]
        public virtual void PutNodeManagementAccess(azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountAccess")]
        public virtual void ResetAccountAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeManagementAccess")]
        public virtual void ResetNodeManagementAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accountAccess", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileAccountAccessOutputReference\"}")]
        public virtual azurerm.BatchAccount.BatchAccountNetworkProfileAccountAccessOutputReference AccountAccess
        {
            get => GetInstanceProperty<azurerm.BatchAccount.BatchAccountNetworkProfileAccountAccessOutputReference>()!;
        }

        [JsiiProperty(name: "nodeManagementAccess", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccessOutputReference\"}")]
        public virtual azurerm.BatchAccount.BatchAccountNetworkProfileNodeManagementAccessOutputReference NodeManagementAccess
        {
            get => GetInstanceProperty<azurerm.BatchAccount.BatchAccountNetworkProfileNodeManagementAccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountAccessInput", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileAccountAccess\"}", isOptional: true)]
        public virtual azurerm.BatchAccount.IBatchAccountNetworkProfileAccountAccess? AccountAccessInput
        {
            get => GetInstanceProperty<azurerm.BatchAccount.IBatchAccountNetworkProfileAccountAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeManagementAccessInput", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccess\"}", isOptional: true)]
        public virtual azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccess? NodeManagementAccessInput
        {
            get => GetInstanceProperty<azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.BatchAccount.IBatchAccountNetworkProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.BatchAccount.IBatchAccountNetworkProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
