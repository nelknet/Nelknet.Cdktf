using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointPostgresSettings), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointPostgresSettings")]
    public interface IDmsEndpointPostgresSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#after_connect_script DmsEndpoint#after_connect_script}.</summary>
        [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AfterConnectScript
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#babelfish_database_name DmsEndpoint#babelfish_database_name}.</summary>
        [JsiiProperty(name: "babelfishDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BabelfishDatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#capture_ddls DmsEndpoint#capture_ddls}.</summary>
        [JsiiProperty(name: "captureDdls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaptureDdls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#database_mode DmsEndpoint#database_mode}.</summary>
        [JsiiProperty(name: "databaseMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#ddl_artifacts_schema DmsEndpoint#ddl_artifacts_schema}.</summary>
        [JsiiProperty(name: "ddlArtifactsSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DdlArtifactsSchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#execute_timeout DmsEndpoint#execute_timeout}.</summary>
        [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExecuteTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#fail_tasks_on_lob_truncation DmsEndpoint#fail_tasks_on_lob_truncation}.</summary>
        [JsiiProperty(name: "failTasksOnLobTruncation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailTasksOnLobTruncation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_enable DmsEndpoint#heartbeat_enable}.</summary>
        [JsiiProperty(name: "heartbeatEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HeartbeatEnable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_frequency DmsEndpoint#heartbeat_frequency}.</summary>
        [JsiiProperty(name: "heartbeatFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HeartbeatFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_schema DmsEndpoint#heartbeat_schema}.</summary>
        [JsiiProperty(name: "heartbeatSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeartbeatSchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_boolean_as_boolean DmsEndpoint#map_boolean_as_boolean}.</summary>
        [JsiiProperty(name: "mapBooleanAsBoolean", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MapBooleanAsBoolean
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_jsonb_as_clob DmsEndpoint#map_jsonb_as_clob}.</summary>
        [JsiiProperty(name: "mapJsonbAsClob", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MapJsonbAsClob
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_long_varchar_as DmsEndpoint#map_long_varchar_as}.</summary>
        [JsiiProperty(name: "mapLongVarcharAs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MapLongVarcharAs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#max_file_size DmsEndpoint#max_file_size}.</summary>
        [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxFileSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#plugin_name DmsEndpoint#plugin_name}.</summary>
        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PluginName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#slot_name DmsEndpoint#slot_name}.</summary>
        [JsiiProperty(name: "slotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SlotName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointPostgresSettings), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointPostgresSettings")]
        internal sealed class _Proxy : DeputyBase, aws.DmsEndpoint.IDmsEndpointPostgresSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#after_connect_script DmsEndpoint#after_connect_script}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AfterConnectScript
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#babelfish_database_name DmsEndpoint#babelfish_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "babelfishDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BabelfishDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#capture_ddls DmsEndpoint#capture_ddls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captureDdls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CaptureDdls
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#database_mode DmsEndpoint#database_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#ddl_artifacts_schema DmsEndpoint#ddl_artifacts_schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ddlArtifactsSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DdlArtifactsSchema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#execute_timeout DmsEndpoint#execute_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExecuteTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#fail_tasks_on_lob_truncation DmsEndpoint#fail_tasks_on_lob_truncation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failTasksOnLobTruncation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FailTasksOnLobTruncation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_enable DmsEndpoint#heartbeat_enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "heartbeatEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HeartbeatEnable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_frequency DmsEndpoint#heartbeat_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "heartbeatFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeartbeatFrequency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_schema DmsEndpoint#heartbeat_schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "heartbeatSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeartbeatSchema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_boolean_as_boolean DmsEndpoint#map_boolean_as_boolean}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mapBooleanAsBoolean", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MapBooleanAsBoolean
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_jsonb_as_clob DmsEndpoint#map_jsonb_as_clob}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mapJsonbAsClob", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MapJsonbAsClob
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_long_varchar_as DmsEndpoint#map_long_varchar_as}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mapLongVarcharAs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MapLongVarcharAs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#max_file_size DmsEndpoint#max_file_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxFileSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#plugin_name DmsEndpoint#plugin_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PluginName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#slot_name DmsEndpoint#slot_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SlotName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
