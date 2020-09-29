import { StateModel } from './state.model';
import { ErrorModel } from '../error/error.model';

export class RegisterModel {
  id: string;
  username: string;
  email: string;
  phonenumber: string;
  password: string;
  passwordconfirm: string;
  lastname: string;
  cpf: string;
  companyname: string;
  cnpj: string;
  cep: string;
  address: string;
  addressnumber: string;
  addresscomplement: string;
  addressstate: StateModel;
  addresscity: string;
  error: ErrorModel;
}
