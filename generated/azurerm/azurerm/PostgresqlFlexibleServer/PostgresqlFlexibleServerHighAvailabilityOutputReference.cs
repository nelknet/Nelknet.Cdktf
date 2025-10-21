using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    [JsiiClass(nativeType: typeof(azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailabilityOutputReference), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PostgresqlFlexibleServerHighAvailabilityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PostgresqlFlexibleServerHighAvailabilityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PostgresqlFlexibleServerHighAvailabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PostgresqlFlexibleServerHighAvailabilityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetStandbyAvailabilityZone")]
        public virtual void ResetStandbyAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "standbyAvailabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StandbyAvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "standbyAvailabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandbyAvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailability\"}", isOptional: true)]
        public virtual azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerHighAvailability? InternalValue
        {
            get => GetInstanceProperty<azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerHighAvailability?>();
            set => SetInstanceProperty(value);
        }
    }
}
