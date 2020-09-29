import { ErrorModel } from '../error/error.model';

export class UserModel {
  id: number;
  username: string;
  email: string;
  password: string;
  token: string;
  error: ErrorModel;
}
