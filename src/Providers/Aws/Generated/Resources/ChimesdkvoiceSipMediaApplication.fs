namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name> = { assignments: ResizeArray<aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application">aws_chimesdkvoice_sip_media_application</a>.
    /// </summary>
    type ChimesdkvoiceSipMediaApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimesdkvoiceSipMediaApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceSipMediaApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : ChimesdkvoiceSipMediaApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceSipMediaApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#aws_region-1">ChimesdkvoiceSipMediaApplication#aws_region</a>.
        /// </summary>
        [<CustomOperation "aws_region">]
        member _.AwsRegion(state: ChimesdkvoiceSipMediaApplicationState<Missing, 'Endpoints, 'Name>, value: string) : ChimesdkvoiceSipMediaApplicationState<Present, 'Endpoints, 'Name> =
            state.assignments.Add(fun config -> config.AwsRegion <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipMediaApplicationState<Present, 'Endpoints, 'Name>)

        /// <summary>
        /// endpoints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#endpoints-1">ChimesdkvoiceSipMediaApplication#endpoints</a>
        /// </summary>
        [<CustomOperation "endpoints">]
        member _.Endpoints(state: ChimesdkvoiceSipMediaApplicationState<'AwsRegion, Missing, 'Name>, value: aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplicationEndpoints) : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, Present, 'Name> =
            state.assignments.Add(fun config -> config.Endpoints <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#name-1">ChimesdkvoiceSipMediaApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, Missing>, value: string) : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#id-1">ChimesdkvoiceSipMediaApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name>, value: string) : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#tags-1">ChimesdkvoiceSipMediaApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name>, value: seq<string * string>) : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#tags_all-1">ChimesdkvoiceSipMediaApplication#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name>, value: seq<string * string>) : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ChimesdkvoiceSipMediaApplicationState<'AwsRegion, 'Endpoints, 'Name>

        member _.Run(state: ChimesdkvoiceSipMediaApplicationState<Present, Present, Present>) : aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplication =
            let config = aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimesdkvoiceSipMediaApplication: missing required arguments. Must call: aws_region, endpoints, name.", 9999, IsError = true)>]
        member _.Run(_: ChimesdkvoiceSipMediaApplicationState<_, _, _>) : aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplication =
            Unchecked.defaultof<aws.ChimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplication>
