namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> = { assignments: ResizeArray<aws.SagemakerWorkteam.SagemakerWorkteamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam">aws_sagemaker_workteam</a>.
    /// </summary>
    type SagemakerWorkteamBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerWorkteamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerWorkteamState<Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerWorkteamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerWorkteamState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#description-1">SagemakerWorkteam#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SagemakerWorkteamState<Missing, 'MemberDefinition, 'WorkteamName>, value: string) : SagemakerWorkteamState<Present, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : SagemakerWorkteamState<Present, 'MemberDefinition, 'WorkteamName>)

        /// <summary>
        /// member_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#member_definition-1">SagemakerWorkteam#member_definition</a> Accepts: aws.IResolvable | aws.SagemakerWorkteam.SagemakerWorkteamMemberDefinition[]
        /// </summary>
        [<CustomOperation "member_definition">]
        member _.MemberDefinition(state: SagemakerWorkteamState<'Description, Missing, 'WorkteamName>, value: HashiCorp.Cdktf.IResolvable) : SagemakerWorkteamState<'Description, Present, 'WorkteamName> =
            state.assignments.Add(fun config -> config.MemberDefinition <- value)
            ({ assignments = state.assignments } : SagemakerWorkteamState<'Description, Present, 'WorkteamName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#workteam_name-1">SagemakerWorkteam#workteam_name</a>.
        /// </summary>
        [<CustomOperation "workteam_name">]
        member _.WorkteamName(state: SagemakerWorkteamState<'Description, 'MemberDefinition, Missing>, value: string) : SagemakerWorkteamState<'Description, 'MemberDefinition, Present> =
            state.assignments.Add(fun config -> config.WorkteamName <- value)
            ({ assignments = state.assignments } : SagemakerWorkteamState<'Description, 'MemberDefinition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#id-1">SagemakerWorkteam#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>, value: string) : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>

        /// <summary>
        /// notification_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#notification_configuration-1">SagemakerWorkteam#notification_configuration</a>
        /// </summary>
        [<CustomOperation "notification_configuration">]
        member _.NotificationConfiguration(state: SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>, value: aws.SagemakerWorkteam.SagemakerWorkteamNotificationConfiguration) : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.NotificationConfiguration <- value)
            state : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#tags-1">SagemakerWorkteam#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>, value: seq<string * string>) : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#tags_all-1">SagemakerWorkteam#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>, value: seq<string * string>) : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>

        /// <summary>
        /// worker_access_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#worker_access_configuration-1">SagemakerWorkteam#worker_access_configuration</a>
        /// </summary>
        [<CustomOperation "worker_access_configuration">]
        member _.WorkerAccessConfiguration(state: SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>, value: aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfiguration) : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.WorkerAccessConfiguration <- value)
            state : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#workforce_name-1">SagemakerWorkteam#workforce_name</a>.
        /// </summary>
        [<CustomOperation "workforce_name">]
        member _.WorkforceName(state: SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>, value: string) : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName> =
            state.assignments.Add(fun config -> config.WorkforceName <- value)
            state : SagemakerWorkteamState<'Description, 'MemberDefinition, 'WorkteamName>

        member _.Run(state: SagemakerWorkteamState<Present, Present, Present>) : aws.SagemakerWorkteam.SagemakerWorkteam =
            let config = aws.SagemakerWorkteam.SagemakerWorkteamConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerWorkteam.SagemakerWorkteam(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerWorkteam: missing required arguments. Must call: description, member_definition, workteam_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerWorkteamState<_, _, _>) : aws.SagemakerWorkteam.SagemakerWorkteam =
            Unchecked.defaultof<aws.SagemakerWorkteam.SagemakerWorkteam>
