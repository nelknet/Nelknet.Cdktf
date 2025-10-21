namespace Nelknet.Cdktf.Providers

open Nelknet.Cdktf

module Random =
    let bytes logicalId = BytesBuilder(logicalId)
    let id logicalId = IdBuilder(logicalId)
    let integer logicalId = IntegerBuilder(logicalId)
    let password logicalId = PasswordBuilder(logicalId)
    let pet logicalId = PetBuilder(logicalId)
    let provider logicalId = RandomProviderBuilder(logicalId)
    let shuffle logicalId = ShuffleBuilder(logicalId)
    let stringResource logicalId = StringResourceBuilder(logicalId)
    let uuid logicalId = UuidBuilder(logicalId)
