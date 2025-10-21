namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotRoleAliasState<'Alias, 'RoleArn> = { assignments: ResizeArray<aws.IotRoleAlias.IotRoleAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias">aws_iot_role_alias</a>.
    /// </summary>
    type IotRoleAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotRoleAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotRoleAliasState<Missing, Missing>)

        member _.Zero(()) : IotRoleAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotRoleAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias#alias-1">IotRoleAlias#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: IotRoleAliasState<Missing, 'RoleArn>, value: string) : IotRoleAliasState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Alias <- value)
            ({ assignments = state.assignments } : IotRoleAliasState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias#role_arn-1">IotRoleAlias#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: IotRoleAliasState<'Alias, Missing>, value: string) : IotRoleAliasState<'Alias, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : IotRoleAliasState<'Alias, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias#credential_duration-1">IotRoleAlias#credential_duration</a>.
        /// </summary>
        [<CustomOperation "credential_duration">]
        member _.CredentialDuration(state: IotRoleAliasState<'Alias, 'RoleArn>, value: double) : IotRoleAliasState<'Alias, 'RoleArn> =
            state.assignments.Add(fun config -> config.CredentialDuration <- value)
            state : IotRoleAliasState<'Alias, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias#id-1">IotRoleAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotRoleAliasState<'Alias, 'RoleArn>, value: string) : IotRoleAliasState<'Alias, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotRoleAliasState<'Alias, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias#tags-1">IotRoleAlias#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotRoleAliasState<'Alias, 'RoleArn>, value: seq<string * string>) : IotRoleAliasState<'Alias, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotRoleAliasState<'Alias, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_role_alias#tags_all-1">IotRoleAlias#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotRoleAliasState<'Alias, 'RoleArn>, value: seq<string * string>) : IotRoleAliasState<'Alias, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotRoleAliasState<'Alias, 'RoleArn>

        member _.Run(state: IotRoleAliasState<Present, Present>) : aws.IotRoleAlias.IotRoleAlias =
            let config = aws.IotRoleAlias.IotRoleAliasConfig()
            for setter in state.assignments do
                setter config
            aws.IotRoleAlias.IotRoleAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotRoleAlias: missing required arguments. Must call: alias, role_arn.", 9999, IsError = true)>]
        member _.Run(_: IotRoleAliasState<_, _>) : aws.IotRoleAlias.IotRoleAlias =
            Unchecked.defaultof<aws.IotRoleAlias.IotRoleAlias>
