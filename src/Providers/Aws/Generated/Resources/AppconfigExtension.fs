namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigExtensionState<'ActionPoint, 'Name> = { assignments: ResizeArray<aws.AppconfigExtension.AppconfigExtensionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension">aws_appconfig_extension</a>.
    /// </summary>
    type AppconfigExtensionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigExtensionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigExtensionState<Missing, Missing>)

        member _.Zero(()) : AppconfigExtensionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigExtensionState<Missing, Missing>)

        /// <summary>
        /// action_point block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#action_point-1">AppconfigExtension#action_point</a> Accepts: aws.IResolvable | aws.AppconfigExtension.AppconfigExtensionActionPoint[]
        /// </summary>
        [<CustomOperation "action_point">]
        member _.ActionPoint(state: AppconfigExtensionState<Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppconfigExtensionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ActionPoint <- value)
            ({ assignments = state.assignments } : AppconfigExtensionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#name-1">AppconfigExtension#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppconfigExtensionState<'ActionPoint, Missing>, value: string) : AppconfigExtensionState<'ActionPoint, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppconfigExtensionState<'ActionPoint, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#description-1">AppconfigExtension#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigExtensionState<'ActionPoint, 'Name>, value: string) : AppconfigExtensionState<'ActionPoint, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigExtensionState<'ActionPoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#id-1">AppconfigExtension#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigExtensionState<'ActionPoint, 'Name>, value: string) : AppconfigExtensionState<'ActionPoint, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigExtensionState<'ActionPoint, 'Name>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#parameter-1">AppconfigExtension#parameter</a> Accepts: aws.IResolvable | aws.AppconfigExtension.AppconfigExtensionParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: AppconfigExtensionState<'ActionPoint, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppconfigExtensionState<'ActionPoint, 'Name> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : AppconfigExtensionState<'ActionPoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#tags-1">AppconfigExtension#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppconfigExtensionState<'ActionPoint, 'Name>, value: seq<string * string>) : AppconfigExtensionState<'ActionPoint, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppconfigExtensionState<'ActionPoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#tags_all-1">AppconfigExtension#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppconfigExtensionState<'ActionPoint, 'Name>, value: seq<string * string>) : AppconfigExtensionState<'ActionPoint, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppconfigExtensionState<'ActionPoint, 'Name>

        member _.Run(state: AppconfigExtensionState<Present, Present>) : aws.AppconfigExtension.AppconfigExtension =
            let config = aws.AppconfigExtension.AppconfigExtensionConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigExtension.AppconfigExtension(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigExtension: missing required arguments. Must call: action_point, name.", 9999, IsError = true)>]
        member _.Run(_: AppconfigExtensionState<_, _>) : aws.AppconfigExtension.AppconfigExtension =
            Unchecked.defaultof<aws.AppconfigExtension.AppconfigExtension>
