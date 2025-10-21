namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldProtectionState<'Name, 'ResourceArn> = { assignments: ResizeArray<aws.ShieldProtection.ShieldProtectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection">aws_shield_protection</a>.
    /// </summary>
    type ShieldProtectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldProtectionState<Missing, Missing>)

        member _.Zero(()) : ShieldProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldProtectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection#name-1">ShieldProtection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ShieldProtectionState<Missing, 'ResourceArn>, value: string) : ShieldProtectionState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ShieldProtectionState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection#resource_arn-1">ShieldProtection#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: ShieldProtectionState<'Name, Missing>, value: string) : ShieldProtectionState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : ShieldProtectionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection#id-1">ShieldProtection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ShieldProtectionState<'Name, 'ResourceArn>, value: string) : ShieldProtectionState<'Name, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ShieldProtectionState<'Name, 'ResourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection#tags-1">ShieldProtection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ShieldProtectionState<'Name, 'ResourceArn>, value: seq<string * string>) : ShieldProtectionState<'Name, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ShieldProtectionState<'Name, 'ResourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection#tags_all-1">ShieldProtection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ShieldProtectionState<'Name, 'ResourceArn>, value: seq<string * string>) : ShieldProtectionState<'Name, 'ResourceArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ShieldProtectionState<'Name, 'ResourceArn>

        member _.Run(state: ShieldProtectionState<Present, Present>) : aws.ShieldProtection.ShieldProtection =
            let config = aws.ShieldProtection.ShieldProtectionConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldProtection.ShieldProtection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldProtection: missing required arguments. Must call: name, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: ShieldProtectionState<_, _>) : aws.ShieldProtection.ShieldProtection =
            Unchecked.defaultof<aws.ShieldProtection.ShieldProtection>
