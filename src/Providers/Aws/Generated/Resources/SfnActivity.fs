namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SfnActivityState<'Name> = { assignments: ResizeArray<aws.SfnActivity.SfnActivityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_activity">aws_sfn_activity</a>.
    /// </summary>
    type SfnActivityBuilder(logicalId: string) =
        member _.Yield(_: unit) : SfnActivityState<Missing> =
            ({ assignments = ResizeArray() } : SfnActivityState<Missing>)

        member _.Zero(()) : SfnActivityState<Missing> =
            ({ assignments = ResizeArray() } : SfnActivityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_activity#name-1">SfnActivity#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SfnActivityState<Missing>, value: string) : SfnActivityState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SfnActivityState<Present>)

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_activity#encryption_configuration-1">SfnActivity#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: SfnActivityState<'Name>, value: aws.SfnActivity.SfnActivityEncryptionConfiguration) : SfnActivityState<'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : SfnActivityState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_activity#id-1">SfnActivity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SfnActivityState<'Name>, value: string) : SfnActivityState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SfnActivityState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_activity#tags-1">SfnActivity#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SfnActivityState<'Name>, value: seq<string * string>) : SfnActivityState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SfnActivityState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_activity#tags_all-1">SfnActivity#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SfnActivityState<'Name>, value: seq<string * string>) : SfnActivityState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SfnActivityState<'Name>

        member _.Run(state: SfnActivityState<Present>) : aws.SfnActivity.SfnActivity =
            let config = aws.SfnActivity.SfnActivityConfig()
            for setter in state.assignments do
                setter config
            aws.SfnActivity.SfnActivity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sfnActivity: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SfnActivityState<_>) : aws.SfnActivity.SfnActivity =
            Unchecked.defaultof<aws.SfnActivity.SfnActivity>
