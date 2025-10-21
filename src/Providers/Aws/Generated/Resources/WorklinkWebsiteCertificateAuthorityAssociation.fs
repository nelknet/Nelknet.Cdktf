namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn> = { assignments: ResizeArray<aws.WorklinkWebsiteCertificateAuthorityAssociation.WorklinkWebsiteCertificateAuthorityAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_website_certificate_authority_association">aws_worklink_website_certificate_authority_association</a>.
    /// </summary>
    type WorklinkWebsiteCertificateAuthorityAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorklinkWebsiteCertificateAuthorityAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WorklinkWebsiteCertificateAuthorityAssociationState<Missing, Missing>)

        member _.Zero(()) : WorklinkWebsiteCertificateAuthorityAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WorklinkWebsiteCertificateAuthorityAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_website_certificate_authority_association#certificate-1">WorklinkWebsiteCertificateAuthorityAssociation#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: WorklinkWebsiteCertificateAuthorityAssociationState<Missing, 'FleetArn>, value: string) : WorklinkWebsiteCertificateAuthorityAssociationState<Present, 'FleetArn> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            ({ assignments = state.assignments } : WorklinkWebsiteCertificateAuthorityAssociationState<Present, 'FleetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_website_certificate_authority_association#fleet_arn-1">WorklinkWebsiteCertificateAuthorityAssociation#fleet_arn</a>.
        /// </summary>
        [<CustomOperation "fleet_arn">]
        member _.FleetArn(state: WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, Missing>, value: string) : WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, Present> =
            state.assignments.Add(fun config -> config.FleetArn <- value)
            ({ assignments = state.assignments } : WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_website_certificate_authority_association#display_name-1">WorklinkWebsiteCertificateAuthorityAssociation#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn>, value: string) : WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_website_certificate_authority_association#id-1">WorklinkWebsiteCertificateAuthorityAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn>, value: string) : WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorklinkWebsiteCertificateAuthorityAssociationState<'Certificate, 'FleetArn>

        member _.Run(state: WorklinkWebsiteCertificateAuthorityAssociationState<Present, Present>) : aws.WorklinkWebsiteCertificateAuthorityAssociation.WorklinkWebsiteCertificateAuthorityAssociation =
            let config = aws.WorklinkWebsiteCertificateAuthorityAssociation.WorklinkWebsiteCertificateAuthorityAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.WorklinkWebsiteCertificateAuthorityAssociation.WorklinkWebsiteCertificateAuthorityAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.worklinkWebsiteCertificateAuthorityAssociation: missing required arguments. Must call: certificate, fleet_arn.", 9999, IsError = true)>]
        member _.Run(_: WorklinkWebsiteCertificateAuthorityAssociationState<_, _>) : aws.WorklinkWebsiteCertificateAuthorityAssociation.WorklinkWebsiteCertificateAuthorityAssociation =
            Unchecked.defaultof<aws.WorklinkWebsiteCertificateAuthorityAssociation.WorklinkWebsiteCertificateAuthorityAssociation>
