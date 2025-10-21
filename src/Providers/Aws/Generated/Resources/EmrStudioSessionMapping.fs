namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId> = { assignments: ResizeArray<aws.EmrStudioSessionMapping.EmrStudioSessionMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping">aws_emr_studio_session_mapping</a>.
    /// </summary>
    type EmrStudioSessionMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrStudioSessionMappingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrStudioSessionMappingState<Missing, Missing, Missing>)

        member _.Zero(()) : EmrStudioSessionMappingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrStudioSessionMappingState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping#identity_type-1">EmrStudioSessionMapping#identity_type</a>.
        /// </summary>
        [<CustomOperation "identity_type">]
        member _.IdentityType(state: EmrStudioSessionMappingState<Missing, 'SessionPolicyArn, 'StudioId>, value: string) : EmrStudioSessionMappingState<Present, 'SessionPolicyArn, 'StudioId> =
            state.assignments.Add(fun config -> config.IdentityType <- value)
            ({ assignments = state.assignments } : EmrStudioSessionMappingState<Present, 'SessionPolicyArn, 'StudioId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping#session_policy_arn-1">EmrStudioSessionMapping#session_policy_arn</a>.
        /// </summary>
        [<CustomOperation "session_policy_arn">]
        member _.SessionPolicyArn(state: EmrStudioSessionMappingState<'IdentityType, Missing, 'StudioId>, value: string) : EmrStudioSessionMappingState<'IdentityType, Present, 'StudioId> =
            state.assignments.Add(fun config -> config.SessionPolicyArn <- value)
            ({ assignments = state.assignments } : EmrStudioSessionMappingState<'IdentityType, Present, 'StudioId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping#studio_id-1">EmrStudioSessionMapping#studio_id</a>.
        /// </summary>
        [<CustomOperation "studio_id">]
        member _.StudioId(state: EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, Missing>, value: string) : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, Present> =
            state.assignments.Add(fun config -> config.StudioId <- value)
            ({ assignments = state.assignments } : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping#id-1">EmrStudioSessionMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId>, value: string) : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping#identity_id-1">EmrStudioSessionMapping#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId>, value: string) : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio_session_mapping#identity_name-1">EmrStudioSessionMapping#identity_name</a>.
        /// </summary>
        [<CustomOperation "identity_name">]
        member _.IdentityName(state: EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId>, value: string) : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId> =
            state.assignments.Add(fun config -> config.IdentityName <- value)
            state : EmrStudioSessionMappingState<'IdentityType, 'SessionPolicyArn, 'StudioId>

        member _.Run(state: EmrStudioSessionMappingState<Present, Present, Present>) : aws.EmrStudioSessionMapping.EmrStudioSessionMapping =
            let config = aws.EmrStudioSessionMapping.EmrStudioSessionMappingConfig()
            for setter in state.assignments do
                setter config
            aws.EmrStudioSessionMapping.EmrStudioSessionMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrStudioSessionMapping: missing required arguments. Must call: identity_type, session_policy_arn, studio_id.", 9999, IsError = true)>]
        member _.Run(_: EmrStudioSessionMappingState<_, _, _>) : aws.EmrStudioSessionMapping.EmrStudioSessionMapping =
            Unchecked.defaultof<aws.EmrStudioSessionMapping.EmrStudioSessionMapping>
