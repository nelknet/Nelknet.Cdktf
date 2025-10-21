namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxMacsecKeyAssociationState<'ConnectionId> = { assignments: ResizeArray<aws.DxMacsecKeyAssociation.DxMacsecKeyAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_macsec_key_association">aws_dx_macsec_key_association</a>.
    /// </summary>
    type DxMacsecKeyAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxMacsecKeyAssociationState<Missing> =
            ({ assignments = ResizeArray() } : DxMacsecKeyAssociationState<Missing>)

        member _.Zero(()) : DxMacsecKeyAssociationState<Missing> =
            ({ assignments = ResizeArray() } : DxMacsecKeyAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_macsec_key_association#connection_id-1">DxMacsecKeyAssociation#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxMacsecKeyAssociationState<Missing>, value: string) : DxMacsecKeyAssociationState<Present> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxMacsecKeyAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_macsec_key_association#cak-1">DxMacsecKeyAssociation#cak</a>.
        /// </summary>
        [<CustomOperation "cak">]
        member _.Cak(state: DxMacsecKeyAssociationState<'ConnectionId>, value: string) : DxMacsecKeyAssociationState<'ConnectionId> =
            state.assignments.Add(fun config -> config.Cak <- value)
            state : DxMacsecKeyAssociationState<'ConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_macsec_key_association#ckn-1">DxMacsecKeyAssociation#ckn</a>.
        /// </summary>
        [<CustomOperation "ckn">]
        member _.Ckn(state: DxMacsecKeyAssociationState<'ConnectionId>, value: string) : DxMacsecKeyAssociationState<'ConnectionId> =
            state.assignments.Add(fun config -> config.Ckn <- value)
            state : DxMacsecKeyAssociationState<'ConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_macsec_key_association#id-1">DxMacsecKeyAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxMacsecKeyAssociationState<'ConnectionId>, value: string) : DxMacsecKeyAssociationState<'ConnectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxMacsecKeyAssociationState<'ConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_macsec_key_association#secret_arn-1">DxMacsecKeyAssociation#secret_arn</a>.
        /// </summary>
        [<CustomOperation "secret_arn">]
        member _.SecretArn(state: DxMacsecKeyAssociationState<'ConnectionId>, value: string) : DxMacsecKeyAssociationState<'ConnectionId> =
            state.assignments.Add(fun config -> config.SecretArn <- value)
            state : DxMacsecKeyAssociationState<'ConnectionId>

        member _.Run(state: DxMacsecKeyAssociationState<Present>) : aws.DxMacsecKeyAssociation.DxMacsecKeyAssociation =
            let config = aws.DxMacsecKeyAssociation.DxMacsecKeyAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DxMacsecKeyAssociation.DxMacsecKeyAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxMacsecKeyAssociation: missing required arguments. Must call: connection_id.", 9999, IsError = true)>]
        member _.Run(_: DxMacsecKeyAssociationState<_>) : aws.DxMacsecKeyAssociation.DxMacsecKeyAssociation =
            Unchecked.defaultof<aws.DxMacsecKeyAssociation.DxMacsecKeyAssociation>
