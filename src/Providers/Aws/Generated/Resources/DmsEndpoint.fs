namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> = { assignments: ResizeArray<aws.DmsEndpoint.DmsEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint">aws_dms_endpoint</a>.
    /// </summary>
    type DmsEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : DmsEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#endpoint_id-1">DmsEndpoint#endpoint_id</a>.
        /// </summary>
        [<CustomOperation "endpoint_id">]
        member _.EndpointId(state: DmsEndpointState<Missing, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<Present, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.EndpointId <- value)
            ({ assignments = state.assignments } : DmsEndpointState<Present, 'EndpointType, 'EngineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#endpoint_type-1">DmsEndpoint#endpoint_type</a>.
        /// </summary>
        [<CustomOperation "endpoint_type">]
        member _.EndpointType(state: DmsEndpointState<'EndpointId, Missing, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, Present, 'EngineName> =
            state.assignments.Add(fun config -> config.EndpointType <- value)
            ({ assignments = state.assignments } : DmsEndpointState<'EndpointId, Present, 'EngineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#engine_name-1">DmsEndpoint#engine_name</a>.
        /// </summary>
        [<CustomOperation "engine_name">]
        member _.EngineName(state: DmsEndpointState<'EndpointId, 'EndpointType, Missing>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, Present> =
            state.assignments.Add(fun config -> config.EngineName <- value)
            ({ assignments = state.assignments } : DmsEndpointState<'EndpointId, 'EndpointType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#certificate_arn-1">DmsEndpoint#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#database_name-1">DmsEndpoint#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// elasticsearch_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#elasticsearch_settings-1">DmsEndpoint#elasticsearch_settings</a>
        /// </summary>
        [<CustomOperation "elasticsearch_settings">]
        member _.ElasticsearchSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointElasticsearchSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.ElasticsearchSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#extra_connection_attributes-1">DmsEndpoint#extra_connection_attributes</a>.
        /// </summary>
        [<CustomOperation "extra_connection_attributes">]
        member _.ExtraConnectionAttributes(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.ExtraConnectionAttributes <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#id-1">DmsEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// kafka_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#kafka_settings-1">DmsEndpoint#kafka_settings</a>
        /// </summary>
        [<CustomOperation "kafka_settings">]
        member _.KafkaSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointKafkaSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.KafkaSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// kinesis_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#kinesis_settings-1">DmsEndpoint#kinesis_settings</a>
        /// </summary>
        [<CustomOperation "kinesis_settings">]
        member _.KinesisSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointKinesisSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.KinesisSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#kms_key_arn-1">DmsEndpoint#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// mongodb_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#mongodb_settings-1">DmsEndpoint#mongodb_settings</a>
        /// </summary>
        [<CustomOperation "mongodb_settings">]
        member _.MongodbSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointMongodbSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.MongodbSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#password-1">DmsEndpoint#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#pause_replication_tasks-1">DmsEndpoint#pause_replication_tasks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "pause_replication_tasks">]
        member _.PauseReplicationTasks(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: bool) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.PauseReplicationTasks <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#pause_replication_tasks-1">DmsEndpoint#pause_replication_tasks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "pause_replication_tasks">]
        member _.PauseReplicationTasks(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: HashiCorp.Cdktf.IResolvable) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.PauseReplicationTasks <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#port-1">DmsEndpoint#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: double) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// postgres_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#postgres_settings-1">DmsEndpoint#postgres_settings</a>
        /// </summary>
        [<CustomOperation "postgres_settings">]
        member _.PostgresSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointPostgresSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.PostgresSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// redis_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#redis_settings-1">DmsEndpoint#redis_settings</a>
        /// </summary>
        [<CustomOperation "redis_settings">]
        member _.RedisSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointRedisSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.RedisSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// redshift_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#redshift_settings-1">DmsEndpoint#redshift_settings</a>
        /// </summary>
        [<CustomOperation "redshift_settings">]
        member _.RedshiftSettings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointRedshiftSettings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.RedshiftSettings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// s3_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#s3_settings-1">DmsEndpoint#s3_settings</a>
        /// </summary>
        [<CustomOperation "s3_settings">]
        member _.S3Settings(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointS3Settings) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.S3Settings <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#secrets_manager_access_role_arn-1">DmsEndpoint#secrets_manager_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "secrets_manager_access_role_arn">]
        member _.SecretsManagerAccessRoleArn(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.SecretsManagerAccessRoleArn <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#secrets_manager_arn-1">DmsEndpoint#secrets_manager_arn</a>.
        /// </summary>
        [<CustomOperation "secrets_manager_arn">]
        member _.SecretsManagerArn(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.SecretsManagerArn <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#server_name-1">DmsEndpoint#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#service_access_role-1">DmsEndpoint#service_access_role</a>.
        /// </summary>
        [<CustomOperation "service_access_role">]
        member _.ServiceAccessRole(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.ServiceAccessRole <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#ssl_mode-1">DmsEndpoint#ssl_mode</a>.
        /// </summary>
        [<CustomOperation "ssl_mode">]
        member _.SslMode(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.SslMode <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#tags-1">DmsEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: seq<string * string>) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#tags_all-1">DmsEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: seq<string * string>) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#timeouts-1">DmsEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: aws.DmsEndpoint.DmsEndpointTimeouts) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#username-1">DmsEndpoint#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>, value: string) : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName> =
            state.assignments.Add(fun config -> config.Username <- value)
            state : DmsEndpointState<'EndpointId, 'EndpointType, 'EngineName>

        member _.Run(state: DmsEndpointState<Present, Present, Present>) : aws.DmsEndpoint.DmsEndpoint =
            let config = aws.DmsEndpoint.DmsEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DmsEndpoint.DmsEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsEndpoint: missing required arguments. Must call: endpoint_id, endpoint_type, engine_name.", 9999, IsError = true)>]
        member _.Run(_: DmsEndpointState<_, _, _>) : aws.DmsEndpoint.DmsEndpoint =
            Unchecked.defaultof<aws.DmsEndpoint.DmsEndpoint>
