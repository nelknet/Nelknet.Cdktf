using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IPostgresqlFlexibleServerHighAvailability), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailability")]
    public interface IPostgresqlFlexibleServerHighAvailability
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#mode PostgresqlFlexibleServer#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#standby_availability_zone PostgresqlFlexibleServer#standby_availability_zone}.</summary>
        [JsiiProperty(name: "standbyAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StandbyAvailabilityZone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPostgresqlFlexibleServerHighAvailability), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailability")]
        internal sealed class _Proxy : DeputyBase, azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerHighAvailability
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#mode PostgresqlFlexibleServer#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#standby_availability_zone PostgresqlFlexibleServer#standby_availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "standbyAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StandbyAvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
