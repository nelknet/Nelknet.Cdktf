namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSignerSigningJobState<'JobId> = { assignments: ResizeArray<aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_job">aws_signer_signing_job</a>.
    /// </summary>
    type DataAwsSignerSigningJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSignerSigningJobState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSignerSigningJobState<Missing>)

        member _.Zero(()) : DataAwsSignerSigningJobState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSignerSigningJobState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_job#job_id-1">DataAwsSignerSigningJob#job_id</a>.
        /// </summary>
        [<CustomOperation "job_id">]
        member _.JobId(state: DataAwsSignerSigningJobState<Missing>, value: string) : DataAwsSignerSigningJobState<Present> =
            state.assignments.Add(fun config -> config.JobId <- value)
            ({ assignments = state.assignments } : DataAwsSignerSigningJobState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_job#id-1">DataAwsSignerSigningJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSignerSigningJobState<'JobId>, value: string) : DataAwsSignerSigningJobState<'JobId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSignerSigningJobState<'JobId>

        member _.Run(state: DataAwsSignerSigningJobState<Present>) : aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob =
            let config = aws.DataAwsSignerSigningJob.DataAwsSignerSigningJobConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSignerSigningJob: missing required arguments. Must call: job_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSignerSigningJobState<_>) : aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob =
            Unchecked.defaultof<aws.DataAwsSignerSigningJob.DataAwsSignerSigningJob>
