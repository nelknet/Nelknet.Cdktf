namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LexSlotTypeState<'EnumerationValue, 'Name> = { assignments: ResizeArray<aws.LexSlotType.LexSlotTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type">aws_lex_slot_type</a>.
    /// </summary>
    type LexSlotTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : LexSlotTypeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LexSlotTypeState<Missing, Missing>)

        member _.Zero(()) : LexSlotTypeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LexSlotTypeState<Missing, Missing>)

        /// <summary>
        /// enumeration_value block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#enumeration_value-1">LexSlotType#enumeration_value</a> Accepts: aws.IResolvable | aws.LexSlotType.LexSlotTypeEnumerationValue[]
        /// </summary>
        [<CustomOperation "enumeration_value">]
        member _.EnumerationValue(state: LexSlotTypeState<Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexSlotTypeState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EnumerationValue <- value)
            ({ assignments = state.assignments } : LexSlotTypeState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#name-1">LexSlotType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LexSlotTypeState<'EnumerationValue, Missing>, value: string) : LexSlotTypeState<'EnumerationValue, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LexSlotTypeState<'EnumerationValue, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#create_version-1">LexSlotType#create_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_version">]
        member _.CreateVersion(state: LexSlotTypeState<'EnumerationValue, 'Name>, value: bool) : LexSlotTypeState<'EnumerationValue, 'Name> =
            state.assignments.Add(fun config -> config.CreateVersion <- value)
            state : LexSlotTypeState<'EnumerationValue, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#create_version-1">LexSlotType#create_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_version">]
        member _.CreateVersion(state: LexSlotTypeState<'EnumerationValue, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexSlotTypeState<'EnumerationValue, 'Name> =
            state.assignments.Add(fun config -> config.CreateVersion <- value)
            state : LexSlotTypeState<'EnumerationValue, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#description-1">LexSlotType#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LexSlotTypeState<'EnumerationValue, 'Name>, value: string) : LexSlotTypeState<'EnumerationValue, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LexSlotTypeState<'EnumerationValue, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#id-1">LexSlotType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LexSlotTypeState<'EnumerationValue, 'Name>, value: string) : LexSlotTypeState<'EnumerationValue, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LexSlotTypeState<'EnumerationValue, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#timeouts-1">LexSlotType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LexSlotTypeState<'EnumerationValue, 'Name>, value: aws.LexSlotType.LexSlotTypeTimeouts) : LexSlotTypeState<'EnumerationValue, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LexSlotTypeState<'EnumerationValue, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#value_selection_strategy-1">LexSlotType#value_selection_strategy</a>.
        /// </summary>
        [<CustomOperation "value_selection_strategy">]
        member _.ValueSelectionStrategy(state: LexSlotTypeState<'EnumerationValue, 'Name>, value: string) : LexSlotTypeState<'EnumerationValue, 'Name> =
            state.assignments.Add(fun config -> config.ValueSelectionStrategy <- value)
            state : LexSlotTypeState<'EnumerationValue, 'Name>

        member _.Run(state: LexSlotTypeState<Present, Present>) : aws.LexSlotType.LexSlotType =
            let config = aws.LexSlotType.LexSlotTypeConfig()
            for setter in state.assignments do
                setter config
            aws.LexSlotType.LexSlotType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexSlotType: missing required arguments. Must call: enumeration_value, name.", 9999, IsError = true)>]
        member _.Run(_: LexSlotTypeState<_, _>) : aws.LexSlotType.LexSlotType =
            Unchecked.defaultof<aws.LexSlotType.LexSlotType>
