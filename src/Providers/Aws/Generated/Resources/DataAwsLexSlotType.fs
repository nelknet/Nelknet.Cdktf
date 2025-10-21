namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLexSlotTypeState<'Name> = { assignments: ResizeArray<aws.DataAwsLexSlotType.DataAwsLexSlotTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_slot_type">aws_lex_slot_type</a>.
    /// </summary>
    type DataAwsLexSlotTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLexSlotTypeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexSlotTypeState<Missing>)

        member _.Zero(()) : DataAwsLexSlotTypeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexSlotTypeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_slot_type#name-1">DataAwsLexSlotType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLexSlotTypeState<Missing>, value: string) : DataAwsLexSlotTypeState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsLexSlotTypeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_slot_type#id-1">DataAwsLexSlotType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLexSlotTypeState<'Name>, value: string) : DataAwsLexSlotTypeState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLexSlotTypeState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_slot_type#version-1">DataAwsLexSlotType#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsLexSlotTypeState<'Name>, value: string) : DataAwsLexSlotTypeState<'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsLexSlotTypeState<'Name>

        member _.Run(state: DataAwsLexSlotTypeState<Present>) : aws.DataAwsLexSlotType.DataAwsLexSlotType =
            let config = aws.DataAwsLexSlotType.DataAwsLexSlotTypeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLexSlotType.DataAwsLexSlotType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLexSlotType: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLexSlotTypeState<_>) : aws.DataAwsLexSlotType.DataAwsLexSlotType =
            Unchecked.defaultof<aws.DataAwsLexSlotType.DataAwsLexSlotType>
