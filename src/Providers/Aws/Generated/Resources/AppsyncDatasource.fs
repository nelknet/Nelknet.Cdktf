namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncDatasourceState<'ApiId, 'Name, 'Type> = { assignments: ResizeArray<aws.AppsyncDatasource.AppsyncDatasourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource">aws_appsync_datasource</a>.
    /// </summary>
    type AppsyncDatasourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncDatasourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncDatasourceState<Missing, Missing, Missing>)

        member _.Zero(()) : AppsyncDatasourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncDatasourceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#api_id-1">AppsyncDatasource#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncDatasourceState<Missing, 'Name, 'Type>, value: string) : AppsyncDatasourceState<Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncDatasourceState<Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#name-1">AppsyncDatasource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppsyncDatasourceState<'ApiId, Missing, 'Type>, value: string) : AppsyncDatasourceState<'ApiId, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppsyncDatasourceState<'ApiId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#type-1">AppsyncDatasource#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AppsyncDatasourceState<'ApiId, 'Name, Missing>, value: string) : AppsyncDatasourceState<'ApiId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : AppsyncDatasourceState<'ApiId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#description-1">AppsyncDatasource#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: string) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// dynamodb_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#dynamodb_config-1">AppsyncDatasource#dynamodb_config</a>
        /// </summary>
        [<CustomOperation "dynamodb_config">]
        member _.DynamodbConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceDynamodbConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.DynamodbConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// elasticsearch_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#elasticsearch_config-1">AppsyncDatasource#elasticsearch_config</a>
        /// </summary>
        [<CustomOperation "elasticsearch_config">]
        member _.ElasticsearchConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceElasticsearchConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.ElasticsearchConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// event_bridge_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#event_bridge_config-1">AppsyncDatasource#event_bridge_config</a>
        /// </summary>
        [<CustomOperation "event_bridge_config">]
        member _.EventBridgeConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceEventBridgeConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.EventBridgeConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// http_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#http_config-1">AppsyncDatasource#http_config</a>
        /// </summary>
        [<CustomOperation "http_config">]
        member _.HttpConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceHttpConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.HttpConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#id-1">AppsyncDatasource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: string) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// lambda_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#lambda_config-1">AppsyncDatasource#lambda_config</a>
        /// </summary>
        [<CustomOperation "lambda_config">]
        member _.LambdaConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceLambdaConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.LambdaConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// opensearchservice_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#opensearchservice_config-1">AppsyncDatasource#opensearchservice_config</a>
        /// </summary>
        [<CustomOperation "opensearchservice_config">]
        member _.OpensearchserviceConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceOpensearchserviceConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.OpensearchserviceConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// relational_database_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#relational_database_config-1">AppsyncDatasource#relational_database_config</a>
        /// </summary>
        [<CustomOperation "relational_database_config">]
        member _.RelationalDatabaseConfig(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: aws.AppsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.RelationalDatabaseConfig <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#service_role_arn-1">AppsyncDatasource#service_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_role_arn">]
        member _.ServiceRoleArn(state: AppsyncDatasourceState<'ApiId, 'Name, 'Type>, value: string) : AppsyncDatasourceState<'ApiId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.ServiceRoleArn <- value)
            state : AppsyncDatasourceState<'ApiId, 'Name, 'Type>

        member _.Run(state: AppsyncDatasourceState<Present, Present, Present>) : aws.AppsyncDatasource.AppsyncDatasource =
            let config = aws.AppsyncDatasource.AppsyncDatasourceConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncDatasource.AppsyncDatasource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncDatasource: missing required arguments. Must call: api_id, name, type.", 9999, IsError = true)>]
        member _.Run(_: AppsyncDatasourceState<_, _, _>) : aws.AppsyncDatasource.AppsyncDatasource =
            Unchecked.defaultof<aws.AppsyncDatasource.AppsyncDatasource>
