namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectPromptState<'InstanceId, 'Name> = { assignments: ResizeArray<aws.DataAwsConnectPrompt.DataAwsConnectPromptConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_prompt">aws_connect_prompt</a>.
    /// </summary>
    type DataAwsConnectPromptBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectPromptState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectPromptState<Missing, Missing>)

        member _.Zero(()) : DataAwsConnectPromptState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectPromptState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_prompt#instance_id-1">DataAwsConnectPrompt#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectPromptState<Missing, 'Name>, value: string) : DataAwsConnectPromptState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectPromptState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_prompt#name-1">DataAwsConnectPrompt#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectPromptState<'InstanceId, Missing>, value: string) : DataAwsConnectPromptState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsConnectPromptState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_prompt#id-1">DataAwsConnectPrompt#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectPromptState<'InstanceId, 'Name>, value: string) : DataAwsConnectPromptState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectPromptState<'InstanceId, 'Name>

        member _.Run(state: DataAwsConnectPromptState<Present, Present>) : aws.DataAwsConnectPrompt.DataAwsConnectPrompt =
            let config = aws.DataAwsConnectPrompt.DataAwsConnectPromptConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectPrompt.DataAwsConnectPrompt(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectPrompt: missing required arguments. Must call: instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectPromptState<_, _>) : aws.DataAwsConnectPrompt.DataAwsConnectPrompt =
            Unchecked.defaultof<aws.DataAwsConnectPrompt.DataAwsConnectPrompt>
