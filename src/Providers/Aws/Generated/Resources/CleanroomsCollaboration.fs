namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> = { assignments: ResizeArray<aws.CleanroomsCollaboration.CleanroomsCollaborationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration">aws_cleanrooms_collaboration</a>.
    /// </summary>
    type CleanroomsCollaborationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CleanroomsCollaborationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CleanroomsCollaborationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CleanroomsCollaborationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CleanroomsCollaborationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#creator_display_name-1">CleanroomsCollaboration#creator_display_name</a>.
        /// </summary>
        [<CustomOperation "creator_display_name">]
        member _.CreatorDisplayName(state: CleanroomsCollaborationState<Missing, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>, value: string) : CleanroomsCollaborationState<Present, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.CreatorDisplayName <- value)
            ({ assignments = state.assignments } : CleanroomsCollaborationState<Present, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#creator_member_abilities-1">CleanroomsCollaboration#creator_member_abilities</a>.
        /// </summary>
        [<CustomOperation "creator_member_abilities">]
        member _.CreatorMemberAbilities(state: CleanroomsCollaborationState<'CreatorDisplayName, Missing, 'Description, 'Name, 'QueryLogStatus>, value: seq<string>) : CleanroomsCollaborationState<'CreatorDisplayName, Present, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.CreatorMemberAbilities <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CleanroomsCollaborationState<'CreatorDisplayName, Present, 'Description, 'Name, 'QueryLogStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#description-1">CleanroomsCollaboration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, Missing, 'Name, 'QueryLogStatus>, value: string) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, Present, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, Present, 'Name, 'QueryLogStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#name-1">CleanroomsCollaboration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, Missing, 'QueryLogStatus>, value: string) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, Present, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, Present, 'QueryLogStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#query_log_status-1">CleanroomsCollaboration#query_log_status</a>.
        /// </summary>
        [<CustomOperation "query_log_status">]
        member _.QueryLogStatus(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, Missing>, value: string) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, Present> =
            state.assignments.Add(fun config -> config.QueryLogStatus <- value)
            ({ assignments = state.assignments } : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, Present>)

        /// <summary>
        /// data_encryption_metadata block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#data_encryption_metadata-1">CleanroomsCollaboration#data_encryption_metadata</a>
        /// </summary>
        [<CustomOperation "data_encryption_metadata">]
        member _.DataEncryptionMetadata(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>, value: aws.CleanroomsCollaboration.CleanroomsCollaborationDataEncryptionMetadata) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.DataEncryptionMetadata <- value)
            state : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>

        /// <summary>
        /// member block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#member-1">CleanroomsCollaboration#member</a> Accepts: aws.IResolvable | aws.CleanroomsCollaboration.CleanroomsCollaborationMember[]
        /// </summary>
        [<CustomOperation "member">]
        member _.Member(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>, value: HashiCorp.Cdktf.IResolvable) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.Member <- value)
            state : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#tags-1">CleanroomsCollaboration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>, value: seq<string * string>) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#tags_all-1">CleanroomsCollaboration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>, value: seq<string * string>) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_collaboration#timeouts-1">CleanroomsCollaboration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>, value: aws.CleanroomsCollaboration.CleanroomsCollaborationTimeouts) : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CleanroomsCollaborationState<'CreatorDisplayName, 'CreatorMemberAbilities, 'Description, 'Name, 'QueryLogStatus>

        member _.Run(state: CleanroomsCollaborationState<Present, Present, Present, Present, Present>) : aws.CleanroomsCollaboration.CleanroomsCollaboration =
            let config = aws.CleanroomsCollaboration.CleanroomsCollaborationConfig()
            for setter in state.assignments do
                setter config
            aws.CleanroomsCollaboration.CleanroomsCollaboration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cleanroomsCollaboration: missing required arguments. Must call: creator_display_name, creator_member_abilities, description, name, query_log_status.", 9999, IsError = true)>]
        member _.Run(_: CleanroomsCollaborationState<_, _, _, _, _>) : aws.CleanroomsCollaboration.CleanroomsCollaboration =
            Unchecked.defaultof<aws.CleanroomsCollaboration.CleanroomsCollaboration>
