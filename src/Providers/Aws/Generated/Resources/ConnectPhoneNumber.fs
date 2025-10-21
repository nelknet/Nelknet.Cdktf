namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> = { assignments: ResizeArray<aws.ConnectPhoneNumber.ConnectPhoneNumberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number">aws_connect_phone_number</a>.
    /// </summary>
    type ConnectPhoneNumberBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectPhoneNumberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectPhoneNumberState<Missing, Missing, Missing>)

        member _.Zero(()) : ConnectPhoneNumberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectPhoneNumberState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#country_code-1">ConnectPhoneNumber#country_code</a>.
        /// </summary>
        [<CustomOperation "country_code">]
        member _.CountryCode(state: ConnectPhoneNumberState<Missing, 'TargetArn, 'Type>, value: string) : ConnectPhoneNumberState<Present, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.CountryCode <- value)
            ({ assignments = state.assignments } : ConnectPhoneNumberState<Present, 'TargetArn, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#target_arn-1">ConnectPhoneNumber#target_arn</a>.
        /// </summary>
        [<CustomOperation "target_arn">]
        member _.TargetArn(state: ConnectPhoneNumberState<'CountryCode, Missing, 'Type>, value: string) : ConnectPhoneNumberState<'CountryCode, Present, 'Type> =
            state.assignments.Add(fun config -> config.TargetArn <- value)
            ({ assignments = state.assignments } : ConnectPhoneNumberState<'CountryCode, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#type-1">ConnectPhoneNumber#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, Missing>, value: string) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ConnectPhoneNumberState<'CountryCode, 'TargetArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#description-1">ConnectPhoneNumber#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>, value: string) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#id-1">ConnectPhoneNumber#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>, value: string) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#prefix-1">ConnectPhoneNumber#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>, value: string) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            state : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#tags-1">ConnectPhoneNumber#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>, value: seq<string * string>) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#tags_all-1">ConnectPhoneNumber#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>, value: seq<string * string>) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_phone_number#timeouts-1">ConnectPhoneNumber#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>, value: aws.ConnectPhoneNumber.ConnectPhoneNumberTimeouts) : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConnectPhoneNumberState<'CountryCode, 'TargetArn, 'Type>

        member _.Run(state: ConnectPhoneNumberState<Present, Present, Present>) : aws.ConnectPhoneNumber.ConnectPhoneNumber =
            let config = aws.ConnectPhoneNumber.ConnectPhoneNumberConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectPhoneNumber.ConnectPhoneNumber(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectPhoneNumber: missing required arguments. Must call: country_code, target_arn, type.", 9999, IsError = true)>]
        member _.Run(_: ConnectPhoneNumberState<_, _, _>) : aws.ConnectPhoneNumber.ConnectPhoneNumber =
            Unchecked.defaultof<aws.ConnectPhoneNumber.ConnectPhoneNumber>
