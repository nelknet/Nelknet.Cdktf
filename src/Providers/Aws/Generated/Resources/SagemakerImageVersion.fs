namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerImageVersionState<'BaseImage, 'ImageName> = { assignments: ResizeArray<aws.SagemakerImageVersion.SagemakerImageVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version">aws_sagemaker_image_version</a>.
    /// </summary>
    type SagemakerImageVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerImageVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerImageVersionState<Missing, Missing>)

        member _.Zero(()) : SagemakerImageVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerImageVersionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#base_image-1">SagemakerImageVersion#base_image</a>.
        /// </summary>
        [<CustomOperation "base_image">]
        member _.BaseImage(state: SagemakerImageVersionState<Missing, 'ImageName>, value: string) : SagemakerImageVersionState<Present, 'ImageName> =
            state.assignments.Add(fun config -> config.BaseImage <- value)
            ({ assignments = state.assignments } : SagemakerImageVersionState<Present, 'ImageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#image_name-1">SagemakerImageVersion#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: SagemakerImageVersionState<'BaseImage, Missing>, value: string) : SagemakerImageVersionState<'BaseImage, Present> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            ({ assignments = state.assignments } : SagemakerImageVersionState<'BaseImage, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#horovod-1">SagemakerImageVersion#horovod</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "horovod">]
        member _.Horovod(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: bool) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.Horovod <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#horovod-1">SagemakerImageVersion#horovod</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "horovod">]
        member _.Horovod(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: HashiCorp.Cdktf.IResolvable) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.Horovod <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#id-1">SagemakerImageVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#job_type-1">SagemakerImageVersion#job_type</a>.
        /// </summary>
        [<CustomOperation "job_type">]
        member _.JobType(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.JobType <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#ml_framework-1">SagemakerImageVersion#ml_framework</a>.
        /// </summary>
        [<CustomOperation "ml_framework">]
        member _.MlFramework(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.MlFramework <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#processor-1">SagemakerImageVersion#processor</a>.
        /// </summary>
        [<CustomOperation "processor">]
        member _.Processor(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.Processor <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#programming_lang-1">SagemakerImageVersion#programming_lang</a>.
        /// </summary>
        [<CustomOperation "programming_lang">]
        member _.ProgrammingLang(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.ProgrammingLang <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#release_notes-1">SagemakerImageVersion#release_notes</a>.
        /// </summary>
        [<CustomOperation "release_notes">]
        member _.ReleaseNotes(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.ReleaseNotes <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image_version#vendor_guidance-1">SagemakerImageVersion#vendor_guidance</a>.
        /// </summary>
        [<CustomOperation "vendor_guidance">]
        member _.VendorGuidance(state: SagemakerImageVersionState<'BaseImage, 'ImageName>, value: string) : SagemakerImageVersionState<'BaseImage, 'ImageName> =
            state.assignments.Add(fun config -> config.VendorGuidance <- value)
            state : SagemakerImageVersionState<'BaseImage, 'ImageName>

        member _.Run(state: SagemakerImageVersionState<Present, Present>) : aws.SagemakerImageVersion.SagemakerImageVersion =
            let config = aws.SagemakerImageVersion.SagemakerImageVersionConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerImageVersion.SagemakerImageVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerImageVersion: missing required arguments. Must call: base_image, image_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerImageVersionState<_, _>) : aws.SagemakerImageVersion.SagemakerImageVersion =
            Unchecked.defaultof<aws.SagemakerImageVersion.SagemakerImageVersion>
