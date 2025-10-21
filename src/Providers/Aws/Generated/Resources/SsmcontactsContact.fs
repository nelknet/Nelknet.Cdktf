namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmcontactsContactState<'Alias, 'Type> = { assignments: ResizeArray<aws.SsmcontactsContact.SsmcontactsContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact">aws_ssmcontacts_contact</a>.
    /// </summary>
    type SsmcontactsContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmcontactsContactState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsContactState<Missing, Missing>)

        member _.Zero(()) : SsmcontactsContactState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsContactState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact#alias-1">SsmcontactsContact#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: SsmcontactsContactState<Missing, 'Type>, value: string) : SsmcontactsContactState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Alias <- value)
            ({ assignments = state.assignments } : SsmcontactsContactState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact#type-1">SsmcontactsContact#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SsmcontactsContactState<'Alias, Missing>, value: string) : SsmcontactsContactState<'Alias, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SsmcontactsContactState<'Alias, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact#display_name-1">SsmcontactsContact#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SsmcontactsContactState<'Alias, 'Type>, value: string) : SsmcontactsContactState<'Alias, 'Type> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SsmcontactsContactState<'Alias, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact#id-1">SsmcontactsContact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmcontactsContactState<'Alias, 'Type>, value: string) : SsmcontactsContactState<'Alias, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmcontactsContactState<'Alias, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact#tags-1">SsmcontactsContact#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmcontactsContactState<'Alias, 'Type>, value: seq<string * string>) : SsmcontactsContactState<'Alias, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmcontactsContactState<'Alias, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact#tags_all-1">SsmcontactsContact#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmcontactsContactState<'Alias, 'Type>, value: seq<string * string>) : SsmcontactsContactState<'Alias, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmcontactsContactState<'Alias, 'Type>

        member _.Run(state: SsmcontactsContactState<Present, Present>) : aws.SsmcontactsContact.SsmcontactsContact =
            let config = aws.SsmcontactsContact.SsmcontactsContactConfig()
            for setter in state.assignments do
                setter config
            aws.SsmcontactsContact.SsmcontactsContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmcontactsContact: missing required arguments. Must call: alias, type.", 9999, IsError = true)>]
        member _.Run(_: SsmcontactsContactState<_, _>) : aws.SsmcontactsContact.SsmcontactsContact =
            Unchecked.defaultof<aws.SsmcontactsContact.SsmcontactsContact>
