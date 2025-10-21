using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiByValue(fqn: "aws.dmsEndpoint.DmsEndpointPostgresSettings")]
    public class DmsEndpointPostgresSettings : aws.DmsEndpoint.IDmsEndpointPostgresSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#after_connect_script DmsEndpoint#after_connect_script}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AfterConnectScript
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#babelfish_database_name DmsEndpoint#babelfish_database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "babelfishDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BabelfishDatabaseName
        {
            get;
            set;
        }

        private object? _captureDdls;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#capture_ddls DmsEndpoint#capture_ddls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captureDdls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CaptureDdls
        {
            get => _captureDdls;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _captureDdls = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#database_mode DmsEndpoint#database_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#ddl_artifacts_schema DmsEndpoint#ddl_artifacts_schema}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ddlArtifactsSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DdlArtifactsSchema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#execute_timeout DmsEndpoint#execute_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExecuteTimeout
        {
            get;
            set;
        }

        private object? _failTasksOnLobTruncation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#fail_tasks_on_lob_truncation DmsEndpoint#fail_tasks_on_lob_truncation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failTasksOnLobTruncation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FailTasksOnLobTruncation
        {
            get => _failTasksOnLobTruncation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _failTasksOnLobTruncation = value;
            }
        }

        private object? _heartbeatEnable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_enable DmsEndpoint#heartbeat_enable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "heartbeatEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HeartbeatEnable
        {
            get => _heartbeatEnable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _heartbeatEnable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_frequency DmsEndpoint#heartbeat_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "heartbeatFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HeartbeatFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#heartbeat_schema DmsEndpoint#heartbeat_schema}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "heartbeatSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeartbeatSchema
        {
            get;
            set;
        }

        private object? _mapBooleanAsBoolean;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_boolean_as_boolean DmsEndpoint#map_boolean_as_boolean}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mapBooleanAsBoolean", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MapBooleanAsBoolean
        {
            get => _mapBooleanAsBoolean;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mapBooleanAsBoolean = value;
            }
        }

        private object? _mapJsonbAsClob;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_jsonb_as_clob DmsEndpoint#map_jsonb_as_clob}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mapJsonbAsClob", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MapJsonbAsClob
        {
            get => _mapJsonbAsClob;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mapJsonbAsClob = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#map_long_varchar_as DmsEndpoint#map_long_varchar_as}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mapLongVarcharAs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MapLongVarcharAs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#max_file_size DmsEndpoint#max_file_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxFileSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#plugin_name DmsEndpoint#plugin_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PluginName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#slot_name DmsEndpoint#slot_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SlotName
        {
            get;
            set;
        }
    }
}
