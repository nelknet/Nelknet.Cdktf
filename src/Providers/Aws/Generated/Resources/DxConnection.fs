namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxConnectionState<'Bandwidth, 'Location, 'Name> = { assignments: ResizeArray<aws.DxConnection.DxConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection">aws_dx_connection</a>.
    /// </summary>
    type DxConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : DxConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#bandwidth-1">DxConnection#bandwidth</a>.
        /// </summary>
        [<CustomOperation "bandwidth">]
        member _.Bandwidth(state: DxConnectionState<Missing, 'Location, 'Name>, value: string) : DxConnectionState<Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Bandwidth <- value)
            ({ assignments = state.assignments } : DxConnectionState<Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#location-1">DxConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DxConnectionState<'Bandwidth, Missing, 'Name>, value: string) : DxConnectionState<'Bandwidth, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DxConnectionState<'Bandwidth, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#name-1">DxConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxConnectionState<'Bandwidth, 'Location, Missing>, value: string) : DxConnectionState<'Bandwidth, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxConnectionState<'Bandwidth, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#encryption_mode-1">DxConnection#encryption_mode</a>.
        /// </summary>
        [<CustomOperation "encryption_mode">]
        member _.EncryptionMode(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: string) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.EncryptionMode <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#id-1">DxConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: string) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#provider_name-1">DxConnection#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: string) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#request_macsec-1">DxConnection#request_macsec</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "request_macsec">]
        member _.RequestMacsec(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: bool) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.RequestMacsec <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#request_macsec-1">DxConnection#request_macsec</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "request_macsec">]
        member _.RequestMacsec(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.RequestMacsec <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#skip_destroy-1">DxConnection#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: bool) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#skip_destroy-1">DxConnection#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#tags-1">DxConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: seq<string * string>) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection#tags_all-1">DxConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxConnectionState<'Bandwidth, 'Location, 'Name>, value: seq<string * string>) : DxConnectionState<'Bandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxConnectionState<'Bandwidth, 'Location, 'Name>

        member _.Run(state: DxConnectionState<Present, Present, Present>) : aws.DxConnection.DxConnection =
            let config = aws.DxConnection.DxConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DxConnection.DxConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxConnection: missing required arguments. Must call: bandwidth, location, name.", 9999, IsError = true)>]
        member _.Run(_: DxConnectionState<_, _, _>) : aws.DxConnection.DxConnection =
            Unchecked.defaultof<aws.DxConnection.DxConnection>
