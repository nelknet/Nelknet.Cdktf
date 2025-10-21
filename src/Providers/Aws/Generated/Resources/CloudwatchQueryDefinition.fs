namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchQueryDefinitionState<'Name, 'QueryString> = { assignments: ResizeArray<aws.CloudwatchQueryDefinition.CloudwatchQueryDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_query_definition">aws_cloudwatch_query_definition</a>.
    /// </summary>
    type CloudwatchQueryDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchQueryDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchQueryDefinitionState<Missing, Missing>)

        member _.Zero(()) : CloudwatchQueryDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchQueryDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_query_definition#name-1">CloudwatchQueryDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchQueryDefinitionState<Missing, 'QueryString>, value: string) : CloudwatchQueryDefinitionState<Present, 'QueryString> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchQueryDefinitionState<Present, 'QueryString>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_query_definition#query_string-1">CloudwatchQueryDefinition#query_string</a>.
        /// </summary>
        [<CustomOperation "query_string">]
        member _.QueryString(state: CloudwatchQueryDefinitionState<'Name, Missing>, value: string) : CloudwatchQueryDefinitionState<'Name, Present> =
            state.assignments.Add(fun config -> config.QueryString <- value)
            ({ assignments = state.assignments } : CloudwatchQueryDefinitionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_query_definition#id-1">CloudwatchQueryDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchQueryDefinitionState<'Name, 'QueryString>, value: string) : CloudwatchQueryDefinitionState<'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchQueryDefinitionState<'Name, 'QueryString>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_query_definition#log_group_names-1">CloudwatchQueryDefinition#log_group_names</a>.
        /// </summary>
        [<CustomOperation "log_group_names">]
        member _.LogGroupNames(state: CloudwatchQueryDefinitionState<'Name, 'QueryString>, value: seq<string>) : CloudwatchQueryDefinitionState<'Name, 'QueryString> =
            state.assignments.Add(fun config -> config.LogGroupNames <- (value |> Seq.toArray))
            state : CloudwatchQueryDefinitionState<'Name, 'QueryString>

        member _.Run(state: CloudwatchQueryDefinitionState<Present, Present>) : aws.CloudwatchQueryDefinition.CloudwatchQueryDefinition =
            let config = aws.CloudwatchQueryDefinition.CloudwatchQueryDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchQueryDefinition.CloudwatchQueryDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchQueryDefinition: missing required arguments. Must call: name, query_string.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchQueryDefinitionState<_, _>) : aws.CloudwatchQueryDefinition.CloudwatchQueryDefinition =
            Unchecked.defaultof<aws.CloudwatchQueryDefinition.CloudwatchQueryDefinition>
