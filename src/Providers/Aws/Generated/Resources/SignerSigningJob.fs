namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignerSigningJobState<'Destination, 'ProfileName, 'Source> = { assignments: ResizeArray<aws.SignerSigningJob.SignerSigningJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job">aws_signer_signing_job</a>.
    /// </summary>
    type SignerSigningJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignerSigningJobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignerSigningJobState<Missing, Missing, Missing>)

        member _.Zero(()) : SignerSigningJobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignerSigningJobState<Missing, Missing, Missing>)

        /// <summary>
        /// destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#destination-1">SignerSigningJob#destination</a>
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: SignerSigningJobState<Missing, 'ProfileName, 'Source>, value: aws.SignerSigningJob.SignerSigningJobDestination) : SignerSigningJobState<Present, 'ProfileName, 'Source> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : SignerSigningJobState<Present, 'ProfileName, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#profile_name-1">SignerSigningJob#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: SignerSigningJobState<'Destination, Missing, 'Source>, value: string) : SignerSigningJobState<'Destination, Present, 'Source> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : SignerSigningJobState<'Destination, Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#source-1">SignerSigningJob#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SignerSigningJobState<'Destination, 'ProfileName, Missing>, value: aws.SignerSigningJob.SignerSigningJobSource) : SignerSigningJobState<'Destination, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : SignerSigningJobState<'Destination, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#id-1">SignerSigningJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignerSigningJobState<'Destination, 'ProfileName, 'Source>, value: string) : SignerSigningJobState<'Destination, 'ProfileName, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignerSigningJobState<'Destination, 'ProfileName, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#ignore_signing_job_failure-1">SignerSigningJob#ignore_signing_job_failure</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_signing_job_failure">]
        member _.IgnoreSigningJobFailure(state: SignerSigningJobState<'Destination, 'ProfileName, 'Source>, value: bool) : SignerSigningJobState<'Destination, 'ProfileName, 'Source> =
            state.assignments.Add(fun config -> config.IgnoreSigningJobFailure <- value)
            state : SignerSigningJobState<'Destination, 'ProfileName, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#ignore_signing_job_failure-1">SignerSigningJob#ignore_signing_job_failure</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_signing_job_failure">]
        member _.IgnoreSigningJobFailure(state: SignerSigningJobState<'Destination, 'ProfileName, 'Source>, value: HashiCorp.Cdktf.IResolvable) : SignerSigningJobState<'Destination, 'ProfileName, 'Source> =
            state.assignments.Add(fun config -> config.IgnoreSigningJobFailure <- value)
            state : SignerSigningJobState<'Destination, 'ProfileName, 'Source>

        member _.Run(state: SignerSigningJobState<Present, Present, Present>) : aws.SignerSigningJob.SignerSigningJob =
            let config = aws.SignerSigningJob.SignerSigningJobConfig()
            for setter in state.assignments do
                setter config
            aws.SignerSigningJob.SignerSigningJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.signerSigningJob: missing required arguments. Must call: destination, profile_name, source.", 9999, IsError = true)>]
        member _.Run(_: SignerSigningJobState<_, _, _>) : aws.SignerSigningJob.SignerSigningJob =
            Unchecked.defaultof<aws.SignerSigningJob.SignerSigningJob>
