namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MedialiveInputState<'Name, 'Type> = { assignments: ResizeArray<aws.MedialiveInput.MedialiveInputConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input">aws_medialive_input</a>.
    /// </summary>
    type MedialiveInputBuilder(logicalId: string) =
        member _.Yield(_: unit) : MedialiveInputState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveInputState<Missing, Missing>)

        member _.Zero(()) : MedialiveInputState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveInputState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#name-1">MedialiveInput#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MedialiveInputState<Missing, 'Type>, value: string) : MedialiveInputState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MedialiveInputState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#type-1">MedialiveInput#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: MedialiveInputState<'Name, Missing>, value: string) : MedialiveInputState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : MedialiveInputState<'Name, Present>)

        /// <summary>
        /// destinations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#destinations-1">MedialiveInput#destinations</a> Accepts: aws.IResolvable | aws.MedialiveInput.MedialiveInputDestinations[]
        /// </summary>
        [<CustomOperation "destinations">]
        member _.Destinations(state: MedialiveInputState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Destinations <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#id-1">MedialiveInput#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MedialiveInputState<'Name, 'Type>, value: string) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// input_devices block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#input_devices-1">MedialiveInput#input_devices</a> Accepts: aws.IResolvable | aws.MedialiveInput.MedialiveInputInputDevices[]
        /// </summary>
        [<CustomOperation "input_devices">]
        member _.InputDevices(state: MedialiveInputState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.InputDevices <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#input_security_groups-1">MedialiveInput#input_security_groups</a>.
        /// </summary>
        [<CustomOperation "input_security_groups">]
        member _.InputSecurityGroups(state: MedialiveInputState<'Name, 'Type>, value: seq<string>) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.InputSecurityGroups <- (value |> Seq.toArray))
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// media_connect_flows block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#media_connect_flows-1">MedialiveInput#media_connect_flows</a> Accepts: aws.IResolvable | aws.MedialiveInput.MedialiveInputMediaConnectFlows[]
        /// </summary>
        [<CustomOperation "media_connect_flows">]
        member _.MediaConnectFlows(state: MedialiveInputState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.MediaConnectFlows <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#role_arn-1">MedialiveInput#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: MedialiveInputState<'Name, 'Type>, value: string) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#sources-1">MedialiveInput#sources</a> Accepts: aws.IResolvable | aws.MedialiveInput.MedialiveInputSources[]
        /// </summary>
        [<CustomOperation "sources">]
        member _.Sources(state: MedialiveInputState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Sources <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#tags-1">MedialiveInput#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MedialiveInputState<'Name, 'Type>, value: seq<string * string>) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#tags_all-1">MedialiveInput#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MedialiveInputState<'Name, 'Type>, value: seq<string * string>) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#timeouts-1">MedialiveInput#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MedialiveInputState<'Name, 'Type>, value: aws.MedialiveInput.MedialiveInputTimeouts) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MedialiveInputState<'Name, 'Type>

        /// <summary>
        /// vpc block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#vpc-1">MedialiveInput#vpc</a>
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: MedialiveInputState<'Name, 'Type>, value: aws.MedialiveInput.MedialiveInputVpc) : MedialiveInputState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : MedialiveInputState<'Name, 'Type>

        member _.Run(state: MedialiveInputState<Present, Present>) : aws.MedialiveInput.MedialiveInput =
            let config = aws.MedialiveInput.MedialiveInputConfig()
            for setter in state.assignments do
                setter config
            aws.MedialiveInput.MedialiveInput(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.medialiveInput: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: MedialiveInputState<_, _>) : aws.MedialiveInput.MedialiveInput =
            Unchecked.defaultof<aws.MedialiveInput.MedialiveInput>
