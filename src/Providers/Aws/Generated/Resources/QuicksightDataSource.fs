namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> = { assignments: ResizeArray<aws.QuicksightDataSource.QuicksightDataSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source">aws_quicksight_data_source</a>.
    /// </summary>
    type QuicksightDataSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightDataSourceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightDataSourceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightDataSourceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightDataSourceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#data_source_id-1">QuicksightDataSource#data_source_id</a>.
        /// </summary>
        [<CustomOperation "data_source_id">]
        member _.DataSourceId(state: QuicksightDataSourceState<Missing, 'Name, 'Parameters, 'Type>, value: string) : QuicksightDataSourceState<Present, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.DataSourceId <- value)
            ({ assignments = state.assignments } : QuicksightDataSourceState<Present, 'Name, 'Parameters, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#name-1">QuicksightDataSource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightDataSourceState<'DataSourceId, Missing, 'Parameters, 'Type>, value: string) : QuicksightDataSourceState<'DataSourceId, Present, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightDataSourceState<'DataSourceId, Present, 'Parameters, 'Type>)

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#parameters-1">QuicksightDataSource#parameters</a>
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: QuicksightDataSourceState<'DataSourceId, 'Name, Missing, 'Type>, value: aws.QuicksightDataSource.QuicksightDataSourceParameters) : QuicksightDataSourceState<'DataSourceId, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            ({ assignments = state.assignments } : QuicksightDataSourceState<'DataSourceId, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#type-1">QuicksightDataSource#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, Missing>, value: string) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aws_account_id-1">QuicksightDataSource#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: string) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// credentials block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#credentials-1">QuicksightDataSource#credentials</a>
        /// </summary>
        [<CustomOperation "credentials">]
        member _.Credentials(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: aws.QuicksightDataSource.QuicksightDataSourceCredentials) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Credentials <- value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#id-1">QuicksightDataSource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: string) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// permission block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#permission-1">QuicksightDataSource#permission</a> Accepts: aws.IResolvable | aws.QuicksightDataSource.QuicksightDataSourcePermission[]
        /// </summary>
        [<CustomOperation "permission">]
        member _.Permission(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Permission <- value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// ssl_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#ssl_properties-1">QuicksightDataSource#ssl_properties</a>
        /// </summary>
        [<CustomOperation "ssl_properties">]
        member _.SslProperties(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: aws.QuicksightDataSource.QuicksightDataSourceSslProperties) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.SslProperties <- value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#tags-1">QuicksightDataSource#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: seq<string * string>) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#tags_all-1">QuicksightDataSource#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: seq<string * string>) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// vpc_connection_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#vpc_connection_properties-1">QuicksightDataSource#vpc_connection_properties</a>
        /// </summary>
        [<CustomOperation "vpc_connection_properties">]
        member _.VpcConnectionProperties(state: QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>, value: aws.QuicksightDataSource.QuicksightDataSourceVpcConnectionProperties) : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.VpcConnectionProperties <- value)
            state : QuicksightDataSourceState<'DataSourceId, 'Name, 'Parameters, 'Type>

        member _.Run(state: QuicksightDataSourceState<Present, Present, Present, Present>) : aws.QuicksightDataSource.QuicksightDataSource =
            let config = aws.QuicksightDataSource.QuicksightDataSourceConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightDataSource.QuicksightDataSource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightDataSource: missing required arguments. Must call: data_source_id, name, parameters, type.", 9999, IsError = true)>]
        member _.Run(_: QuicksightDataSourceState<_, _, _, _>) : aws.QuicksightDataSource.QuicksightDataSource =
            Unchecked.defaultof<aws.QuicksightDataSource.QuicksightDataSource>
