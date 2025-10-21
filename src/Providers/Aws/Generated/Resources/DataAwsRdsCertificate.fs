namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsCertificateState = { assignments: ResizeArray<aws.DataAwsRdsCertificate.DataAwsRdsCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_certificate">aws_rds_certificate</a>.
    /// </summary>
    type DataAwsRdsCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsCertificateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRdsCertificateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_certificate#default_for_new_launches-1">DataAwsRdsCertificate#default_for_new_launches</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_for_new_launches">]
        member _.DefaultForNewLaunches(state: DataAwsRdsCertificateState, value: bool) : DataAwsRdsCertificateState =
            state.assignments.Add(fun config -> config.DefaultForNewLaunches <- value)
            state : DataAwsRdsCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_certificate#default_for_new_launches-1">DataAwsRdsCertificate#default_for_new_launches</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_for_new_launches">]
        member _.DefaultForNewLaunches(state: DataAwsRdsCertificateState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsCertificateState =
            state.assignments.Add(fun config -> config.DefaultForNewLaunches <- value)
            state : DataAwsRdsCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_certificate#id-1">DataAwsRdsCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRdsCertificateState, value: string) : DataAwsRdsCertificateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRdsCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_certificate#latest_valid_till-1">DataAwsRdsCertificate#latest_valid_till</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest_valid_till">]
        member _.LatestValidTill(state: DataAwsRdsCertificateState, value: bool) : DataAwsRdsCertificateState =
            state.assignments.Add(fun config -> config.LatestValidTill <- value)
            state : DataAwsRdsCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_certificate#latest_valid_till-1">DataAwsRdsCertificate#latest_valid_till</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest_valid_till">]
        member _.LatestValidTill(state: DataAwsRdsCertificateState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsCertificateState =
            state.assignments.Add(fun config -> config.LatestValidTill <- value)
            state : DataAwsRdsCertificateState

        member _.Run(state: DataAwsRdsCertificateState) : aws.DataAwsRdsCertificate.DataAwsRdsCertificate =
            let config = aws.DataAwsRdsCertificate.DataAwsRdsCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsCertificate.DataAwsRdsCertificate(StackContext.get (), logicalId, config)
