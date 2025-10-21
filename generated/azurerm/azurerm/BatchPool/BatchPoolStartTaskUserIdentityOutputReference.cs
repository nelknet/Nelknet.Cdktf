using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.BatchPool.BatchPoolStartTaskUserIdentityOutputReference), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskUserIdentityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchPoolStartTaskUserIdentityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchPoolStartTaskUserIdentityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchPoolStartTaskUserIdentityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPoolStartTaskUserIdentityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser\"}}]")]
        public virtual void PutAutoUser(azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoUser")]
        public virtual void ResetAutoUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserName")]
        public virtual void ResetUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoUser", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUserOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolStartTaskUserIdentityAutoUserOutputReference AutoUser
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolStartTaskUserIdentityAutoUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoUserInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser? AutoUserInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentity\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolStartTaskUserIdentity? InternalValue
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTaskUserIdentity?>();
            set => SetInstanceProperty(value);
        }
    }
}
