namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> = { assignments: ResizeArray<aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack">aws_serverlessapplicationrepository_cloudformation_stack</a>.
    /// </summary>
    type ServerlessapplicationrepositoryCloudformationStackBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServerlessapplicationrepositoryCloudformationStackState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServerlessapplicationrepositoryCloudformationStackState<Missing, Missing, Missing>)

        member _.Zero(()) : ServerlessapplicationrepositoryCloudformationStackState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServerlessapplicationrepositoryCloudformationStackState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#application_id-1">ServerlessapplicationrepositoryCloudformationStack#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: ServerlessapplicationrepositoryCloudformationStackState<Missing, 'Capabilities, 'Name>, value: string) : ServerlessapplicationrepositoryCloudformationStackState<Present, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : ServerlessapplicationrepositoryCloudformationStackState<Present, 'Capabilities, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#capabilities-1">ServerlessapplicationrepositoryCloudformationStack#capabilities</a>.
        /// </summary>
        [<CustomOperation "capabilities">]
        member _.Capabilities(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, Missing, 'Name>, value: seq<string>) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Capabilities <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#name-1">ServerlessapplicationrepositoryCloudformationStack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, Missing>, value: string) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#id-1">ServerlessapplicationrepositoryCloudformationStack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>, value: string) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#parameters-1">ServerlessapplicationrepositoryCloudformationStack#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>, value: seq<string * string>) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#semantic_version-1">ServerlessapplicationrepositoryCloudformationStack#semantic_version</a>.
        /// </summary>
        [<CustomOperation "semantic_version">]
        member _.SemanticVersion(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>, value: string) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.SemanticVersion <- value)
            state : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#tags-1">ServerlessapplicationrepositoryCloudformationStack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>, value: seq<string * string>) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#tags_all-1">ServerlessapplicationrepositoryCloudformationStack#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>, value: seq<string * string>) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/serverlessapplicationrepository_cloudformation_stack#timeouts-1">ServerlessapplicationrepositoryCloudformationStack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>, value: aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStackTimeouts) : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServerlessapplicationrepositoryCloudformationStackState<'ApplicationId, 'Capabilities, 'Name>

        member _.Run(state: ServerlessapplicationrepositoryCloudformationStackState<Present, Present, Present>) : aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStack =
            let config = aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStackConfig()
            for setter in state.assignments do
                setter config
            aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.serverlessapplicationrepositoryCloudformationStack: missing required arguments. Must call: application_id, capabilities, name.", 9999, IsError = true)>]
        member _.Run(_: ServerlessapplicationrepositoryCloudformationStackState<_, _, _>) : aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStack =
            Unchecked.defaultof<aws.ServerlessapplicationrepositoryCloudformationStack.ServerlessapplicationrepositoryCloudformationStack>
