namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeServiceState<'Name> = { assignments: ResizeArray<aws.VpclatticeService.VpclatticeServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service">aws_vpclattice_service</a>.
    /// </summary>
    type VpclatticeServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeServiceState<Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceState<Missing>)

        member _.Zero(()) : VpclatticeServiceState<Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#name-1">VpclatticeService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeServiceState<Missing>, value: string) : VpclatticeServiceState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeServiceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#auth_type-1">VpclatticeService#auth_type</a>.
        /// </summary>
        [<CustomOperation "auth_type">]
        member _.AuthType(state: VpclatticeServiceState<'Name>, value: string) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.AuthType <- value)
            state : VpclatticeServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#certificate_arn-1">VpclatticeService#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: VpclatticeServiceState<'Name>, value: string) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : VpclatticeServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#custom_domain_name-1">VpclatticeService#custom_domain_name</a>.
        /// </summary>
        [<CustomOperation "custom_domain_name">]
        member _.CustomDomainName(state: VpclatticeServiceState<'Name>, value: string) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.CustomDomainName <- value)
            state : VpclatticeServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#id-1">VpclatticeService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeServiceState<'Name>, value: string) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#tags-1">VpclatticeService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeServiceState<'Name>, value: seq<string * string>) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#tags_all-1">VpclatticeService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeServiceState<'Name>, value: seq<string * string>) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeServiceState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service#timeouts-1">VpclatticeService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeServiceState<'Name>, value: aws.VpclatticeService.VpclatticeServiceTimeouts) : VpclatticeServiceState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeServiceState<'Name>

        member _.Run(state: VpclatticeServiceState<Present>) : aws.VpclatticeService.VpclatticeService =
            let config = aws.VpclatticeService.VpclatticeServiceConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeService.VpclatticeService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeService: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeServiceState<_>) : aws.VpclatticeService.VpclatticeService =
            Unchecked.defaultof<aws.VpclatticeService.VpclatticeService>
