namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RamResourceShareState<'Name> = { assignments: ResizeArray<aws.RamResourceShare.RamResourceShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share">aws_ram_resource_share</a>.
    /// </summary>
    type RamResourceShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : RamResourceShareState<Missing> =
            ({ assignments = ResizeArray() } : RamResourceShareState<Missing>)

        member _.Zero(()) : RamResourceShareState<Missing> =
            ({ assignments = ResizeArray() } : RamResourceShareState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#name-1">RamResourceShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RamResourceShareState<Missing>, value: string) : RamResourceShareState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RamResourceShareState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#allow_external_principals-1">RamResourceShare#allow_external_principals</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_external_principals">]
        member _.AllowExternalPrincipals(state: RamResourceShareState<'Name>, value: bool) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.AllowExternalPrincipals <- value)
            state : RamResourceShareState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#allow_external_principals-1">RamResourceShare#allow_external_principals</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_external_principals">]
        member _.AllowExternalPrincipals(state: RamResourceShareState<'Name>, value: HashiCorp.Cdktf.IResolvable) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.AllowExternalPrincipals <- value)
            state : RamResourceShareState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#id-1">RamResourceShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RamResourceShareState<'Name>, value: string) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RamResourceShareState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#permission_arns-1">RamResourceShare#permission_arns</a>.
        /// </summary>
        [<CustomOperation "permission_arns">]
        member _.PermissionArns(state: RamResourceShareState<'Name>, value: seq<string>) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.PermissionArns <- (value |> Seq.toArray))
            state : RamResourceShareState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#tags-1">RamResourceShare#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RamResourceShareState<'Name>, value: seq<string * string>) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RamResourceShareState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#tags_all-1">RamResourceShare#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RamResourceShareState<'Name>, value: seq<string * string>) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RamResourceShareState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share#timeouts-1">RamResourceShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RamResourceShareState<'Name>, value: aws.RamResourceShare.RamResourceShareTimeouts) : RamResourceShareState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RamResourceShareState<'Name>

        member _.Run(state: RamResourceShareState<Present>) : aws.RamResourceShare.RamResourceShare =
            let config = aws.RamResourceShare.RamResourceShareConfig()
            for setter in state.assignments do
                setter config
            aws.RamResourceShare.RamResourceShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ramResourceShare: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: RamResourceShareState<_>) : aws.RamResourceShare.RamResourceShare =
            Unchecked.defaultof<aws.RamResourceShare.RamResourceShare>
