import { Injectable } from '@angular/core';

@Injectable()
export class AppConfig {

    private config: { [key: string]: string };

    constructor() {

        this.config = {

            PathBackEndAPI: 'http://localhost:5000/api/'

        };

    }

    get setting(): { [key: string]: string } {

        return this.config;

    }

    get(key: any) {

        return this.config[key];

    }

}
