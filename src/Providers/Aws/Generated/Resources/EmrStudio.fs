namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> = { assignments: ResizeArray<aws.EmrStudio.EmrStudioConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio">aws_emr_studio</a>.
    /// </summary>
    type EmrStudioBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrStudioState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrStudioState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EmrStudioState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrStudioState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#auth_mode-1">EmrStudio#auth_mode</a>.
        /// </summary>
        [<CustomOperation "auth_mode">]
        member _.AuthMode(state: EmrStudioState<Missing, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<Present, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.AuthMode <- value)
            ({ assignments = state.assignments } : EmrStudioState<Present, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#default_s3_location-1">EmrStudio#default_s3_location</a>.
        /// </summary>
        [<CustomOperation "default_s3_location">]
        member _.DefaultS3Location(state: EmrStudioState<'AuthMode, Missing, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, Present, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.DefaultS3Location <- value)
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, Present, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#engine_security_group_id-1">EmrStudio#engine_security_group_id</a>.
        /// </summary>
        [<CustomOperation "engine_security_group_id">]
        member _.EngineSecurityGroupId(state: EmrStudioState<'AuthMode, 'DefaultS3Location, Missing, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, Present, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.EngineSecurityGroupId <- value)
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, 'DefaultS3Location, Present, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#name-1">EmrStudio#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, Missing, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, Present, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, Present, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#service_role-1">EmrStudio#service_role</a>.
        /// </summary>
        [<CustomOperation "service_role">]
        member _.ServiceRole(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, Missing, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, Present, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.ServiceRole <- value)
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, Present, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#subnet_ids-1">EmrStudio#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, Missing, 'VpcId, 'WorkspaceSecurityGroupId>, value: seq<string>) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, Present, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, Present, 'VpcId, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#vpc_id-1">EmrStudio#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, Missing, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, Present, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, Present, 'WorkspaceSecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#workspace_security_group_id-1">EmrStudio#workspace_security_group_id</a>.
        /// </summary>
        [<CustomOperation "workspace_security_group_id">]
        member _.WorkspaceSecurityGroupId(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, Missing>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceSecurityGroupId <- value)
            ({ assignments = state.assignments } : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#description-1">EmrStudio#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#encryption_key_arn-1">EmrStudio#encryption_key_arn</a>.
        /// </summary>
        [<CustomOperation "encryption_key_arn">]
        member _.EncryptionKeyArn(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.EncryptionKeyArn <- value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#id-1">EmrStudio#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#idp_auth_url-1">EmrStudio#idp_auth_url</a>.
        /// </summary>
        [<CustomOperation "idp_auth_url">]
        member _.IdpAuthUrl(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.IdpAuthUrl <- value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#idp_relay_state_parameter_name-1">EmrStudio#idp_relay_state_parameter_name</a>.
        /// </summary>
        [<CustomOperation "idp_relay_state_parameter_name">]
        member _.IdpRelayStateParameterName(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.IdpRelayStateParameterName <- value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#tags-1">EmrStudio#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: seq<string * string>) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#tags_all-1">EmrStudio#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: seq<string * string>) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_studio#user_role-1">EmrStudio#user_role</a>.
        /// </summary>
        [<CustomOperation "user_role">]
        member _.UserRole(state: EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>, value: string) : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId> =
            state.assignments.Add(fun config -> config.UserRole <- value)
            state : EmrStudioState<'AuthMode, 'DefaultS3Location, 'EngineSecurityGroupId, 'Name, 'ServiceRole, 'SubnetIds, 'VpcId, 'WorkspaceSecurityGroupId>

        member _.Run(state: EmrStudioState<Present, Present, Present, Present, Present, Present, Present, Present>) : aws.EmrStudio.EmrStudio =
            let config = aws.EmrStudio.EmrStudioConfig()
            for setter in state.assignments do
                setter config
            aws.EmrStudio.EmrStudio(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrStudio: missing required arguments. Must call: auth_mode, default_s3_location, engine_security_group_id, name, service_role, subnet_ids, vpc_id, workspace_security_group_id.", 9999, IsError = true)>]
        member _.Run(_: EmrStudioState<_, _, _, _, _, _, _, _>) : aws.EmrStudio.EmrStudio =
            Unchecked.defaultof<aws.EmrStudio.EmrStudio>
