namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ControltowerLandingZoneState<'ManifestJson, 'Version> = { assignments: ResizeArray<aws.ControltowerLandingZone.ControltowerLandingZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone">aws_controltower_landing_zone</a>.
    /// </summary>
    type ControltowerLandingZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : ControltowerLandingZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ControltowerLandingZoneState<Missing, Missing>)

        member _.Zero(()) : ControltowerLandingZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ControltowerLandingZoneState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone#manifest_json-1">ControltowerLandingZone#manifest_json</a>.
        /// </summary>
        [<CustomOperation "manifest_json">]
        member _.ManifestJson(state: ControltowerLandingZoneState<Missing, 'Version>, value: string) : ControltowerLandingZoneState<Present, 'Version> =
            state.assignments.Add(fun config -> config.ManifestJson <- value)
            ({ assignments = state.assignments } : ControltowerLandingZoneState<Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone#version-1">ControltowerLandingZone#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ControltowerLandingZoneState<'ManifestJson, Missing>, value: string) : ControltowerLandingZoneState<'ManifestJson, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ControltowerLandingZoneState<'ManifestJson, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone#id-1">ControltowerLandingZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ControltowerLandingZoneState<'ManifestJson, 'Version>, value: string) : ControltowerLandingZoneState<'ManifestJson, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ControltowerLandingZoneState<'ManifestJson, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone#tags-1">ControltowerLandingZone#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ControltowerLandingZoneState<'ManifestJson, 'Version>, value: seq<string * string>) : ControltowerLandingZoneState<'ManifestJson, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ControltowerLandingZoneState<'ManifestJson, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone#tags_all-1">ControltowerLandingZone#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ControltowerLandingZoneState<'ManifestJson, 'Version>, value: seq<string * string>) : ControltowerLandingZoneState<'ManifestJson, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ControltowerLandingZoneState<'ManifestJson, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_landing_zone#timeouts-1">ControltowerLandingZone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ControltowerLandingZoneState<'ManifestJson, 'Version>, value: aws.ControltowerLandingZone.ControltowerLandingZoneTimeouts) : ControltowerLandingZoneState<'ManifestJson, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ControltowerLandingZoneState<'ManifestJson, 'Version>

        member _.Run(state: ControltowerLandingZoneState<Present, Present>) : aws.ControltowerLandingZone.ControltowerLandingZone =
            let config = aws.ControltowerLandingZone.ControltowerLandingZoneConfig()
            for setter in state.assignments do
                setter config
            aws.ControltowerLandingZone.ControltowerLandingZone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.controltowerLandingZone: missing required arguments. Must call: manifest_json, version.", 9999, IsError = true)>]
        member _.Run(_: ControltowerLandingZoneState<_, _>) : aws.ControltowerLandingZone.ControltowerLandingZone =
            Unchecked.defaultof<aws.ControltowerLandingZone.ControltowerLandingZone>
