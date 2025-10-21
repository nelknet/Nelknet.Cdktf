namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RolesanywhereProfileState<'Name> = { assignments: ResizeArray<aws.RolesanywhereProfile.RolesanywhereProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile">aws_rolesanywhere_profile</a>.
    /// </summary>
    type RolesanywhereProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : RolesanywhereProfileState<Missing> =
            ({ assignments = ResizeArray() } : RolesanywhereProfileState<Missing>)

        member _.Zero(()) : RolesanywhereProfileState<Missing> =
            ({ assignments = ResizeArray() } : RolesanywhereProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#name-1">RolesanywhereProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RolesanywhereProfileState<Missing>, value: string) : RolesanywhereProfileState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RolesanywhereProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#duration_seconds-1">RolesanywhereProfile#duration_seconds</a>.
        /// </summary>
        [<CustomOperation "duration_seconds">]
        member _.DurationSeconds(state: RolesanywhereProfileState<'Name>, value: double) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.DurationSeconds <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#enabled-1">RolesanywhereProfile#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: RolesanywhereProfileState<'Name>, value: bool) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#enabled-1">RolesanywhereProfile#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: RolesanywhereProfileState<'Name>, value: HashiCorp.Cdktf.IResolvable) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#id-1">RolesanywhereProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RolesanywhereProfileState<'Name>, value: string) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#managed_policy_arns-1">RolesanywhereProfile#managed_policy_arns</a>.
        /// </summary>
        [<CustomOperation "managed_policy_arns">]
        member _.ManagedPolicyArns(state: RolesanywhereProfileState<'Name>, value: seq<string>) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.ManagedPolicyArns <- (value |> Seq.toArray))
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#require_instance_properties-1">RolesanywhereProfile#require_instance_properties</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_instance_properties">]
        member _.RequireInstanceProperties(state: RolesanywhereProfileState<'Name>, value: bool) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.RequireInstanceProperties <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#require_instance_properties-1">RolesanywhereProfile#require_instance_properties</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_instance_properties">]
        member _.RequireInstanceProperties(state: RolesanywhereProfileState<'Name>, value: HashiCorp.Cdktf.IResolvable) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.RequireInstanceProperties <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#role_arns-1">RolesanywhereProfile#role_arns</a>.
        /// </summary>
        [<CustomOperation "role_arns">]
        member _.RoleArns(state: RolesanywhereProfileState<'Name>, value: seq<string>) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.RoleArns <- (value |> Seq.toArray))
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#session_policy-1">RolesanywhereProfile#session_policy</a>.
        /// </summary>
        [<CustomOperation "session_policy">]
        member _.SessionPolicy(state: RolesanywhereProfileState<'Name>, value: string) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.SessionPolicy <- value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#tags-1">RolesanywhereProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RolesanywhereProfileState<'Name>, value: seq<string * string>) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RolesanywhereProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_profile#tags_all-1">RolesanywhereProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RolesanywhereProfileState<'Name>, value: seq<string * string>) : RolesanywhereProfileState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RolesanywhereProfileState<'Name>

        member _.Run(state: RolesanywhereProfileState<Present>) : aws.RolesanywhereProfile.RolesanywhereProfile =
            let config = aws.RolesanywhereProfile.RolesanywhereProfileConfig()
            for setter in state.assignments do
                setter config
            aws.RolesanywhereProfile.RolesanywhereProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rolesanywhereProfile: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: RolesanywhereProfileState<_>) : aws.RolesanywhereProfile.RolesanywhereProfile =
            Unchecked.defaultof<aws.RolesanywhereProfile.RolesanywhereProfile>
