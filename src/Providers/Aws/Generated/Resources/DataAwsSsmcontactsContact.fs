namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmcontactsContactState<'Arn> = { assignments: ResizeArray<aws.DataAwsSsmcontactsContact.DataAwsSsmcontactsContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact">aws_ssmcontacts_contact</a>.
    /// </summary>
    type DataAwsSsmcontactsContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmcontactsContactState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsContactState<Missing>)

        member _.Zero(()) : DataAwsSsmcontactsContactState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsContactState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact#arn-1">DataAwsSsmcontactsContact#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSsmcontactsContactState<Missing>, value: string) : DataAwsSsmcontactsContactState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsSsmcontactsContactState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact#id-1">DataAwsSsmcontactsContact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmcontactsContactState<'Arn>, value: string) : DataAwsSsmcontactsContactState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmcontactsContactState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact#tags-1">DataAwsSsmcontactsContact#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSsmcontactsContactState<'Arn>, value: seq<string * string>) : DataAwsSsmcontactsContactState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSsmcontactsContactState<'Arn>

        member _.Run(state: DataAwsSsmcontactsContactState<Present>) : aws.DataAwsSsmcontactsContact.DataAwsSsmcontactsContact =
            let config = aws.DataAwsSsmcontactsContact.DataAwsSsmcontactsContactConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmcontactsContact.DataAwsSsmcontactsContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmcontactsContact: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmcontactsContactState<_>) : aws.DataAwsSsmcontactsContact.DataAwsSsmcontactsContact =
            Unchecked.defaultof<aws.DataAwsSsmcontactsContact.DataAwsSsmcontactsContact>
